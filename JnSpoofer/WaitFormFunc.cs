using System;
using System.Threading;
using System.Windows.Forms;

namespace JnSpoofer
{
	// Token: 0x02000017 RID: 23
	public class WaitFormFunc
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00002492 File Offset: 0x00000692
		public void Show()
		{
			this.loadthread = new Thread(new ThreadStart(this.LoadingProcess));
			this.loadthread.Start();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000024B6 File Offset: 0x000006B6
		public void Show(Form parent)
		{
			this.loadthread = new Thread(new ParameterizedThreadStart(this.LoadingProcess));
			this.loadthread.Start(parent);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009364 File Offset: 0x00007564
		public void Close()
		{
			if (this.wait != null)
			{
				this.wait.BeginInvoke(new ThreadStart(this.wait.CloseWaitForm));
				this.wait = null;
				this.loadthread = null;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024DB File Offset: 0x000006DB
		private void LoadingProcess()
		{
			this.wait = new WaitForm();
			this.wait.ShowDialog();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000093A8 File Offset: 0x000075A8
		private void LoadingProcess(object parent)
		{
			Form parent2 = parent as Form;
			this.wait = new WaitForm(parent2);
			this.wait.ShowDialog();
		}

		// Token: 0x04000098 RID: 152
		private WaitForm wait;

		// Token: 0x04000099 RID: 153
		private Thread loadthread;
	}
}
