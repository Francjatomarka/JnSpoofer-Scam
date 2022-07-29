using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000F RID: 15
	public class json_wrapper
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000238A File Offset: 0x0000058A
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004214 File Offset: 0x00002414
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004268 File Offset: 0x00002468
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000023A8 File Offset: 0x000005A8
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400003A RID: 58
		private DataContractJsonSerializer serializer;

		// Token: 0x0400003B RID: 59
		private object current_object;
	}
}
