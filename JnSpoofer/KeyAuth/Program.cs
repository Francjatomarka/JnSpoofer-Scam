using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002408 File Offset: 0x00000608
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
