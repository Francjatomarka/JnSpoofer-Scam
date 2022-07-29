using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using JnSpoofer;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000011 RID: 17
	public partial class Login : Form
	{
		// Token: 0x06000095 RID: 149
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000096 RID: 150
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000097 RID: 151
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
		}

		// Token: 0x06000098 RID: 152
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.upgrade(this.username.Text, this.key.Text);
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}

		// Token: 0x06000099 RID: 153
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			new Form1().Show();
			base.Hide();
		}

		// Token: 0x0600009A RID: 154
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Form1().Show();
				base.Hide();
				return;
			}
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}

		// Token: 0x0600009B RID: 155
		private void LicBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.license(this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Main().Show();
				base.Hide();
				return;
			}
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}

		// Token: 0x0600009C RID: 156
		private void label4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/TNkaG9rZ3f");
		}

		// Token: 0x0600009D RID: 157
		private void siticoneControlBox4_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600009E RID: 158
		private void siticoneControlBox3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000058 RID: 88
		private static string name = "JnSpoofer";

		// Token: 0x04000059 RID: 89
		private static string ownerid = "pojlQv9hMS";

		// Token: 0x0400005A RID: 90
		private static string secret = "e75531a5ed59e34b32b1bd17c2c436e7f71fde293c85477a3ef6bc51c6d80d12";

		// Token: 0x0400005B RID: 91
		private static string version = "3.0";

		// Token: 0x0400005C RID: 92
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
