using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using JnSpoofer.Properties;

namespace JnSpoofer
{
	// Token: 0x02000016 RID: 22
	public partial class WaitForm : Form
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00002476 File Offset: 0x00000676
		public WaitForm()
		{
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.CenterParent;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000911C File Offset: 0x0000731C
		public WaitForm(Form parent)
		{
			this.InitializeComponent();
			if (parent != null)
			{
				base.StartPosition = FormStartPosition.Manual;
				base.Location = new Point(parent.Location.X + parent.Width / 2 - base.Width / 2, parent.Location.Y + parent.Height / 2 - base.Height / 2);
			}
			else
			{
				base.StartPosition = FormStartPosition.CenterParent;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000091A0 File Offset: 0x000073A0
		public void CloseWaitForm()
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
			if (this.label1.Image != null)
			{
				this.label1.Image.Dispose();
			}
		}
	}
}
