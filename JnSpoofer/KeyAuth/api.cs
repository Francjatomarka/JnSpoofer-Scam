using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public class api
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000029D4 File Offset: 0x00000BD4
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A68 File Offset: 0x00000C68
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public void register(string username, string pass, string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002D68 File Offset: 0x00000F68
		public void login(string username, string pass)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002EC8 File Offset: 0x000010C8
		public void upgrade(string username, string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003000 File Offset: 0x00001200
		public void license(string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003148 File Offset: 0x00001348
		public void setvar(string var, string data)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003268 File Offset: 0x00001468
		public string getvar(string var)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003384 File Offset: 0x00001584
		public void ban()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003474 File Offset: 0x00001674
		public string var(string varid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000035A4 File Offset: 0x000017A4
		public List<api.msg> chatget(string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			List<api.msg> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000036C0 File Offset: 0x000018C0
		public bool chatsend(string msg, string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000037F0 File Offset: 0x000019F0
		public bool checkblack()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000391C File Offset: 0x00001B1C
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			string result;
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
				result = null;
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
				nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
				nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
				nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
				nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				this.load_response_struct(response_structure);
				if (response_structure.success)
				{
					result = response_structure.response;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A8C File Offset: 0x00001C8C
		public byte[] download(string fileid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			byte[] result;
			if (response_structure.success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public void log(string message)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003D28 File Offset: 0x00001F28
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D78 File Offset: 0x00001F78
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003E24 File Offset: 0x00002024
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003E88 File Offset: 0x00002088
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020AB File Offset: 0x000002AB
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000008 RID: 8
		public string name;

		// Token: 0x04000009 RID: 9
		public string ownerid;

		// Token: 0x0400000A RID: 10
		public string secret;

		// Token: 0x0400000B RID: 11
		public string version;

		// Token: 0x0400000C RID: 12
		private string sessionid;

		// Token: 0x0400000D RID: 13
		private string enckey;

		// Token: 0x0400000E RID: 14
		private bool initzalized;

		// Token: 0x0400000F RID: 15
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000010 RID: 16
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000011 RID: 17
		public api.response_class response = new api.response_class();

		// Token: 0x04000012 RID: 18
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000006 RID: 6
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000029 RID: 41 RVA: 0x000020CF File Offset: 0x000002CF
			// (set) Token: 0x0600002A RID: 42 RVA: 0x000020D7 File Offset: 0x000002D7
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600002B RID: 43 RVA: 0x000020E0 File Offset: 0x000002E0
			// (set) Token: 0x0600002C RID: 44 RVA: 0x000020E8 File Offset: 0x000002E8
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600002D RID: 45 RVA: 0x000020F1 File Offset: 0x000002F1
			// (set) Token: 0x0600002E RID: 46 RVA: 0x000020F9 File Offset: 0x000002F9
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00002102 File Offset: 0x00000302
			// (set) Token: 0x06000030 RID: 48 RVA: 0x0000210A File Offset: 0x0000030A
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00002113 File Offset: 0x00000313
			// (set) Token: 0x06000032 RID: 50 RVA: 0x0000211B File Offset: 0x0000031B
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00002124 File Offset: 0x00000324
			// (set) Token: 0x06000034 RID: 52 RVA: 0x0000212C File Offset: 0x0000032C
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002135 File Offset: 0x00000335
			// (set) Token: 0x06000036 RID: 54 RVA: 0x0000213D File Offset: 0x0000033D
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000037 RID: 55 RVA: 0x00002146 File Offset: 0x00000346
			// (set) Token: 0x06000038 RID: 56 RVA: 0x0000214E File Offset: 0x0000034E
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000039 RID: 57 RVA: 0x00002157 File Offset: 0x00000357
			// (set) Token: 0x0600003A RID: 58 RVA: 0x0000215F File Offset: 0x0000035F
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000007 RID: 7
		public class msg
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002170 File Offset: 0x00000370
			// (set) Token: 0x0600003D RID: 61 RVA: 0x00002178 File Offset: 0x00000378
			public string message { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00002181 File Offset: 0x00000381
			// (set) Token: 0x0600003F RID: 63 RVA: 0x00002189 File Offset: 0x00000389
			public string author { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00002192 File Offset: 0x00000392
			// (set) Token: 0x06000041 RID: 65 RVA: 0x0000219A File Offset: 0x0000039A
			public string timestamp { get; set; }
		}

		// Token: 0x02000008 RID: 8
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000043 RID: 67 RVA: 0x000021A3 File Offset: 0x000003A3
			// (set) Token: 0x06000044 RID: 68 RVA: 0x000021AB File Offset: 0x000003AB
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000045 RID: 69 RVA: 0x000021B4 File Offset: 0x000003B4
			// (set) Token: 0x06000046 RID: 70 RVA: 0x000021BC File Offset: 0x000003BC
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000047 RID: 71 RVA: 0x000021C5 File Offset: 0x000003C5
			// (set) Token: 0x06000048 RID: 72 RVA: 0x000021CD File Offset: 0x000003CD
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000049 RID: 73 RVA: 0x000021D6 File Offset: 0x000003D6
			// (set) Token: 0x0600004A RID: 74 RVA: 0x000021DE File Offset: 0x000003DE
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600004B RID: 75 RVA: 0x000021E7 File Offset: 0x000003E7
			// (set) Token: 0x0600004C RID: 76 RVA: 0x000021EF File Offset: 0x000003EF
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600004D RID: 77 RVA: 0x000021F8 File Offset: 0x000003F8
			// (set) Token: 0x0600004E RID: 78 RVA: 0x00002200 File Offset: 0x00000400
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000009 RID: 9
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00002209 File Offset: 0x00000409
			// (set) Token: 0x06000051 RID: 81 RVA: 0x00002211 File Offset: 0x00000411
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000052 RID: 82 RVA: 0x0000221A File Offset: 0x0000041A
			// (set) Token: 0x06000053 RID: 83 RVA: 0x00002222 File Offset: 0x00000422
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000054 RID: 84 RVA: 0x0000222B File Offset: 0x0000042B
			// (set) Token: 0x06000055 RID: 85 RVA: 0x00002233 File Offset: 0x00000433
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000056 RID: 86 RVA: 0x0000223C File Offset: 0x0000043C
			// (set) Token: 0x06000057 RID: 87 RVA: 0x00002244 File Offset: 0x00000444
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000058 RID: 88 RVA: 0x0000224D File Offset: 0x0000044D
			// (set) Token: 0x06000059 RID: 89 RVA: 0x00002255 File Offset: 0x00000455
			[DataMember]
			public string customerPanelLink { get; set; }
		}

		// Token: 0x0200000A RID: 10
		public class app_data_class
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600005B RID: 91 RVA: 0x0000225E File Offset: 0x0000045E
			// (set) Token: 0x0600005C RID: 92 RVA: 0x00002266 File Offset: 0x00000466
			public string numUsers { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600005D RID: 93 RVA: 0x0000226F File Offset: 0x0000046F
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00002277 File Offset: 0x00000477
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005F RID: 95 RVA: 0x00002280 File Offset: 0x00000480
			// (set) Token: 0x06000060 RID: 96 RVA: 0x00002288 File Offset: 0x00000488
			public string numKeys { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00002291 File Offset: 0x00000491
			// (set) Token: 0x06000062 RID: 98 RVA: 0x00002299 File Offset: 0x00000499
			public string version { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000063 RID: 99 RVA: 0x000022A2 File Offset: 0x000004A2
			// (set) Token: 0x06000064 RID: 100 RVA: 0x000022AA File Offset: 0x000004AA
			public string customerPanelLink { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class user_data_class
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000066 RID: 102 RVA: 0x000022B3 File Offset: 0x000004B3
			// (set) Token: 0x06000067 RID: 103 RVA: 0x000022BB File Offset: 0x000004BB
			public string username { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000068 RID: 104 RVA: 0x000022C4 File Offset: 0x000004C4
			// (set) Token: 0x06000069 RID: 105 RVA: 0x000022CC File Offset: 0x000004CC
			public string ip { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600006A RID: 106 RVA: 0x000022D5 File Offset: 0x000004D5
			// (set) Token: 0x0600006B RID: 107 RVA: 0x000022DD File Offset: 0x000004DD
			public string hwid { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600006C RID: 108 RVA: 0x000022E6 File Offset: 0x000004E6
			// (set) Token: 0x0600006D RID: 109 RVA: 0x000022EE File Offset: 0x000004EE
			public string createdate { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600006E RID: 110 RVA: 0x000022F7 File Offset: 0x000004F7
			// (set) Token: 0x0600006F RID: 111 RVA: 0x000022FF File Offset: 0x000004FF
			public string lastlogin { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00002308 File Offset: 0x00000508
			// (set) Token: 0x06000071 RID: 113 RVA: 0x00002310 File Offset: 0x00000510
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000C RID: 12
		public class Data
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000073 RID: 115 RVA: 0x00002319 File Offset: 0x00000519
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00002321 File Offset: 0x00000521
			public string subscription { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000075 RID: 117 RVA: 0x0000232A File Offset: 0x0000052A
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00002332 File Offset: 0x00000532
			public string expiry { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000077 RID: 119 RVA: 0x0000233B File Offset: 0x0000053B
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00002343 File Offset: 0x00000543
			public string timeleft { get; set; }
		}

		// Token: 0x0200000D RID: 13
		public class response_class
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600007A RID: 122 RVA: 0x0000234C File Offset: 0x0000054C
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00002354 File Offset: 0x00000554
			public bool success { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600007C RID: 124 RVA: 0x0000235D File Offset: 0x0000055D
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00002365 File Offset: 0x00000565
			public string message { get; set; }
		}
	}
}
