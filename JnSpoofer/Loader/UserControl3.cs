using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Loader
{
	// Token: 0x02000004 RID: 4
	public class UserControl3 : UserControl
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002096 File Offset: 0x00000296
		public UserControl3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000294C File Offset: 0x00000B4C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000297C File Offset: 0x00000B7C
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "UserControl3";
			base.Size = new Size(516, 411);
			base.ResumeLayout(false);
		}

		// Token: 0x04000007 RID: 7
		private IContainer components = null;
	}
}
