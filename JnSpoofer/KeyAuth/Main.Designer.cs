namespace KeyAuth
{
	// Token: 0x02000010 RID: 16
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000093 RID: 147 RVA: 0x000046D4 File Offset: 0x000028D4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004704 File Offset: 0x00002904
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.key = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.subscription = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Sender = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Message = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sendmsg = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.chatmsg = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.ip = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.hwid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.createDate = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.lastLogin = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.numUsers = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.numOnlineUsers = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.numKeys = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.version = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.customerPanelLink = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(573, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(528, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(87, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "Loader Main";
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.key, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.key.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.key.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.key.Location = new global::System.Drawing.Point(20, 60);
			this.key.Margin = new global::System.Windows.Forms.Padding(2);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(82, 15);
			this.key.TabIndex = 37;
			this.key.Text = "usernameLabel";
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.expiry, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(20, 80);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(63, 15);
			this.expiry.TabIndex = 38;
			this.expiry.Text = "expiryLabel";
			this.expiry.Click += new global::System.EventHandler(this.expiry_Click);
			this.subscription.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.subscription, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.subscription.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.subscription.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.subscription.Location = new global::System.Drawing.Point(20, 101);
			this.subscription.Margin = new global::System.Windows.Forms.Padding(2);
			this.subscription.Name = "subscription";
			this.subscription.Size = new global::System.Drawing.Size(95, 15);
			this.subscription.TabIndex = 39;
			this.subscription.Text = "subscriptionLabel";
			this.subscription.Click += new global::System.EventHandler(this.subscription_Click);
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Sender,
				this.Message,
				this.Time
			});
			this.siticoneTransition1.SetDecoration(this.dataGridView1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.dataGridView1.Location = new global::System.Drawing.Point(64, 255);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new global::System.Drawing.Size(493, 227);
			this.dataGridView1.TabIndex = 41;
			this.Sender.HeaderText = "Sender";
			this.Sender.Name = "Sender";
			this.Sender.Width = 75;
			this.Message.HeaderText = "Message";
			this.Message.Name = "Message";
			this.Message.Width = 200;
			this.Time.HeaderText = "Time";
			this.Time.MaxInputLength = 50000;
			this.Time.Name = "Time";
			this.Time.Width = 175;
			this.sendmsg.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.sendmsg.BorderThickness = 1;
			this.sendmsg.CheckedState.Parent = this.sendmsg;
			this.sendmsg.CustomImages.Parent = this.sendmsg;
			this.siticoneTransition1.SetDecoration(this.sendmsg, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.sendmsg.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.sendmsg.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sendmsg.ForeColor = global::System.Drawing.Color.White;
			this.sendmsg.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.sendmsg.HoveredState.Parent = this.sendmsg;
			this.sendmsg.Location = new global::System.Drawing.Point(406, 488);
			this.sendmsg.Name = "sendmsg";
			this.sendmsg.ShadowDecoration.Parent = this.sendmsg;
			this.sendmsg.Size = new global::System.Drawing.Size(151, 27);
			this.sendmsg.TabIndex = 42;
			this.sendmsg.Text = "Send";
			this.sendmsg.Click += new global::System.EventHandler(this.sendmsg_Click);
			this.chatmsg.AllowDrop = true;
			this.chatmsg.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.chatmsg.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.chatmsg, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.chatmsg.DefaultText = "Your message here";
			this.chatmsg.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.chatmsg.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.chatmsg.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.chatmsg.DisabledState.Parent = this.chatmsg;
			this.chatmsg.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.chatmsg.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.chatmsg.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.chatmsg.FocusedState.Parent = this.chatmsg;
			this.chatmsg.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.chatmsg.HoveredState.Parent = this.chatmsg;
			this.chatmsg.Location = new global::System.Drawing.Point(64, 485);
			this.chatmsg.Margin = new global::System.Windows.Forms.Padding(4);
			this.chatmsg.Name = "chatmsg";
			this.chatmsg.PasswordChar = '\0';
			this.chatmsg.PlaceholderText = "";
			this.chatmsg.SelectedText = "";
			this.chatmsg.ShadowDecoration.Parent = this.chatmsg;
			this.chatmsg.Size = new global::System.Drawing.Size(335, 30);
			this.chatmsg.TabIndex = 43;
			this.chatmsg.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ip.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.ip, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.ip.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ip.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.ip.Location = new global::System.Drawing.Point(20, 119);
			this.ip.Margin = new global::System.Windows.Forms.Padding(2);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(41, 15);
			this.ip.TabIndex = 44;
			this.ip.Text = "ipLabel";
			this.hwid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.hwid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.hwid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hwid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.hwid.Location = new global::System.Drawing.Point(20, 137);
			this.hwid.Margin = new global::System.Windows.Forms.Padding(2);
			this.hwid.Name = "hwid";
			this.hwid.Size = new global::System.Drawing.Size(57, 15);
			this.hwid.TabIndex = 45;
			this.hwid.Text = "hwidLabel";
			this.createDate.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.createDate, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.createDate.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.createDate.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.createDate.Location = new global::System.Drawing.Point(20, 155);
			this.createDate.Margin = new global::System.Windows.Forms.Padding(2);
			this.createDate.Name = "createDate";
			this.createDate.Size = new global::System.Drawing.Size(86, 15);
			this.createDate.TabIndex = 46;
			this.createDate.Text = "createDateLabel";
			this.lastLogin.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.lastLogin, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.lastLogin.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lastLogin.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.lastLogin.Location = new global::System.Drawing.Point(20, 173);
			this.lastLogin.Margin = new global::System.Windows.Forms.Padding(2);
			this.lastLogin.Name = "lastLogin";
			this.lastLogin.Size = new global::System.Drawing.Size(79, 15);
			this.lastLogin.TabIndex = 47;
			this.lastLogin.Text = "lastLoginLabel";
			this.numUsers.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.numUsers, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.numUsers.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numUsers.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.numUsers.Location = new global::System.Drawing.Point(325, 60);
			this.numUsers.Margin = new global::System.Windows.Forms.Padding(2);
			this.numUsers.Name = "numUsers";
			this.numUsers.Size = new global::System.Drawing.Size(83, 15);
			this.numUsers.TabIndex = 48;
			this.numUsers.Text = "numUsersLabel";
			this.numOnlineUsers.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.numOnlineUsers, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.numOnlineUsers.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numOnlineUsers.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.numOnlineUsers.Location = new global::System.Drawing.Point(325, 80);
			this.numOnlineUsers.Margin = new global::System.Windows.Forms.Padding(2);
			this.numOnlineUsers.Name = "numOnlineUsers";
			this.numOnlineUsers.Size = new global::System.Drawing.Size(117, 15);
			this.numOnlineUsers.TabIndex = 49;
			this.numOnlineUsers.Text = "numOnlineUsersLabel";
			this.numKeys.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.numKeys, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.numKeys.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numKeys.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.numKeys.Location = new global::System.Drawing.Point(325, 101);
			this.numKeys.Margin = new global::System.Windows.Forms.Padding(2);
			this.numKeys.Name = "numKeys";
			this.numKeys.Size = new global::System.Drawing.Size(79, 15);
			this.numKeys.TabIndex = 50;
			this.numKeys.Text = "numKeysLabel";
			this.version.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.version, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.version.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.version.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.version.Location = new global::System.Drawing.Point(325, 119);
			this.version.Margin = new global::System.Windows.Forms.Padding(2);
			this.version.Name = "version";
			this.version.Size = new global::System.Drawing.Size(69, 15);
			this.version.TabIndex = 51;
			this.version.Text = "versionLabel";
			this.customerPanelLink.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.customerPanelLink, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.customerPanelLink.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.customerPanelLink.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.customerPanelLink.Location = new global::System.Drawing.Point(325, 137);
			this.customerPanelLink.Margin = new global::System.Windows.Forms.Padding(2);
			this.customerPanelLink.Name = "customerPanelLink";
			this.customerPanelLink.Size = new global::System.Drawing.Size(130, 15);
			this.customerPanelLink.TabIndex = 52;
			this.customerPanelLink.Text = "customerPanelLinkLabel";
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			base.ClientSize = new global::System.Drawing.Size(622, 543);
			base.Controls.Add(this.customerPanelLink);
			base.Controls.Add(this.version);
			base.Controls.Add(this.numKeys);
			base.Controls.Add(this.numOnlineUsers);
			base.Controls.Add(this.numUsers);
			base.Controls.Add(this.lastLogin);
			base.Controls.Add(this.createDate);
			base.Controls.Add(this.hwid);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.chatmsg);
			base.Controls.Add(this.sendmsg);
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.subscription);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.key);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003D RID: 61
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003E RID: 62
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400003F RID: 63
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000040 RID: 64
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000041 RID: 65
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000044 RID: 68
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000045 RID: 69
		private global::Siticone.UI.WinForms.SiticoneLabel subscription;

		// Token: 0x04000046 RID: 70
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x04000047 RID: 71
		private global::Siticone.UI.WinForms.SiticoneLabel key;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Sender;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Message;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Time;

		// Token: 0x0400004C RID: 76
		private global::Siticone.UI.WinForms.SiticoneRoundedButton sendmsg;

		// Token: 0x0400004D RID: 77
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox chatmsg;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400004F RID: 79
		private global::Siticone.UI.WinForms.SiticoneLabel ip;

		// Token: 0x04000050 RID: 80
		private global::Siticone.UI.WinForms.SiticoneLabel hwid;

		// Token: 0x04000051 RID: 81
		private global::Siticone.UI.WinForms.SiticoneLabel createDate;

		// Token: 0x04000052 RID: 82
		private global::Siticone.UI.WinForms.SiticoneLabel lastLogin;

		// Token: 0x04000053 RID: 83
		private global::Siticone.UI.WinForms.SiticoneLabel numUsers;

		// Token: 0x04000054 RID: 84
		private global::Siticone.UI.WinForms.SiticoneLabel numOnlineUsers;

		// Token: 0x04000055 RID: 85
		private global::Siticone.UI.WinForms.SiticoneLabel numKeys;

		// Token: 0x04000056 RID: 86
		private global::Siticone.UI.WinForms.SiticoneLabel customerPanelLink;

		// Token: 0x04000057 RID: 87
		private global::Siticone.UI.WinForms.SiticoneLabel version;
	}
}
