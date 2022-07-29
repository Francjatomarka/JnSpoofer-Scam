namespace KeyAuth
{
	// Token: 0x02000011 RID: 17
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009F RID: 159
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A0 RID: 160
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LoginBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.username = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.password = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.RgstrBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.UpgradeBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.LicBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.status = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.key = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.siticoneControlBox3 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox4 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(412, 4);
			this.siticoneControlBox1.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(46, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(366, 4);
			this.siticoneControlBox2.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(46, 29);
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
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.LoginBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.BorderThickness = 1;
			this.LoginBtn.CheckedState.Parent = this.LoginBtn;
			this.LoginBtn.CustomImages.Parent = this.LoginBtn;
			this.siticoneTransition1.SetDecoration(this.LoginBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.LoginBtn.FillColor = global::System.Drawing.Color.Black;
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.White;
			this.LoginBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LoginBtn.HoveredState.Parent = this.LoginBtn;
			this.LoginBtn.Location = new global::System.Drawing.Point(32, 323);
			this.LoginBtn.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
			this.LoginBtn.Size = new global::System.Drawing.Size(76, 27);
			this.LoginBtn.TabIndex = 26;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click);
			this.username.AllowDrop = true;
			this.username.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.username.BorderColor = global::System.Drawing.Color.Black;
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.Black;
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.FocusedState.Parent = this.username;
			this.username.ForeColor = global::System.Drawing.Color.Gray;
			this.username.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.HoveredState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(32, 126);
			this.username.Margin = new global::System.Windows.Forms.Padding(2);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(192, 43);
			this.username.TabIndex = 33;
			this.username.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.password.AllowDrop = true;
			this.password.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.password.BorderColor = global::System.Drawing.Color.Black;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.password, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.Black;
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.FocusedState.Parent = this.password;
			this.password.ForeColor = global::System.Drawing.Color.Gray;
			this.password.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.HoveredState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(32, 196);
			this.password.Margin = new global::System.Windows.Forms.Padding(2);
			this.password.Name = "password";
			this.password.PasswordChar = '•';
			this.password.PlaceholderText = "";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(192, 43);
			this.password.TabIndex = 34;
			this.password.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.RgstrBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.BorderThickness = 1;
			this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
			this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
			this.siticoneTransition1.SetDecoration(this.RgstrBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.RgstrBtn.FillColor = global::System.Drawing.Color.Black;
			this.RgstrBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RgstrBtn.ForeColor = global::System.Drawing.Color.White;
			this.RgstrBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
			this.RgstrBtn.Location = new global::System.Drawing.Point(148, 323);
			this.RgstrBtn.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
			this.RgstrBtn.Size = new global::System.Drawing.Size(76, 27);
			this.RgstrBtn.TabIndex = 35;
			this.RgstrBtn.Text = "Register";
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click);
			this.UpgradeBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.UpgradeBtn.BorderThickness = 1;
			this.UpgradeBtn.CheckedState.Parent = this.UpgradeBtn;
			this.UpgradeBtn.CustomImages.Parent = this.UpgradeBtn;
			this.siticoneTransition1.SetDecoration(this.UpgradeBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.UpgradeBtn.FillColor = global::System.Drawing.Color.Black;
			this.UpgradeBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.UpgradeBtn.ForeColor = global::System.Drawing.Color.White;
			this.UpgradeBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.UpgradeBtn.HoveredState.Parent = this.UpgradeBtn;
			this.UpgradeBtn.Location = new global::System.Drawing.Point(32, 356);
			this.UpgradeBtn.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.UpgradeBtn.Name = "UpgradeBtn";
			this.UpgradeBtn.ShadowDecoration.Parent = this.UpgradeBtn;
			this.UpgradeBtn.Size = new global::System.Drawing.Size(76, 27);
			this.UpgradeBtn.TabIndex = 36;
			this.UpgradeBtn.Text = "Upgrade";
			this.UpgradeBtn.Click += new global::System.EventHandler(this.UpgradeBtn_Click);
			this.LicBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.LicBtn.BorderThickness = 1;
			this.LicBtn.CheckedState.Parent = this.LicBtn;
			this.LicBtn.CustomImages.Parent = this.LicBtn;
			this.siticoneTransition1.SetDecoration(this.LicBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.LicBtn.FillColor = global::System.Drawing.Color.Black;
			this.LicBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LicBtn.ForeColor = global::System.Drawing.Color.White;
			this.LicBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LicBtn.HoveredState.Parent = this.LicBtn;
			this.LicBtn.Location = new global::System.Drawing.Point(148, 356);
			this.LicBtn.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.LicBtn.Name = "LicBtn";
			this.LicBtn.ShadowDecoration.Parent = this.LicBtn;
			this.LicBtn.Size = new global::System.Drawing.Size(76, 27);
			this.LicBtn.TabIndex = 37;
			this.LicBtn.Text = "License";
			this.LicBtn.Click += new global::System.EventHandler(this.LicBtn_Click);
			this.status.AutoSize = false;
			this.status.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.status, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.status.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.status.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.status.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.status.Location = new global::System.Drawing.Point(0, 385);
			this.status.Margin = new global::System.Windows.Forms.Padding(2);
			this.status.Name = "status";
			this.status.Size = new global::System.Drawing.Size(250, 42);
			this.status.TabIndex = 38;
			this.status.Text = "Status: Awaiting login";
			this.status.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.key.AllowDrop = true;
			this.key.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.key.BorderColor = global::System.Drawing.Color.Black;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.key, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.Black;
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.FocusedState.Parent = this.key;
			this.key.ForeColor = global::System.Drawing.Color.Gray;
			this.key.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.HoveredState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(32, 261);
			this.key.Margin = new global::System.Windows.Forms.Padding(2);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.key.PlaceholderText = "";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(192, 43);
			this.key.TabIndex = 32;
			this.key.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Arial", 36f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new global::System.Drawing.Point(55, 35);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(143, 55);
			this.label2.TabIndex = 39;
			this.label2.Text = "ғᴏʀsᴀ";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new global::System.Drawing.Point(40, 110);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(64, 14);
			this.label3.TabIndex = 40;
			this.label3.Text = "Username";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new global::System.Drawing.Point(40, 180);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(63, 14);
			this.label4.TabIndex = 41;
			this.label4.Text = "Password";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTransition1.SetDecoration(this.label5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new global::System.Drawing.Point(40, 245);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(27, 14);
			this.label5.TabIndex = 42;
			this.label5.Text = "Key";
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTransition1.SetDecoration(this.label6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label6.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label6.Location = new global::System.Drawing.Point(47, 90);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(158, 14);
			this.label6.TabIndex = 43;
			this.label6.Text = "Sign in to continue to forsa.";
			this.siticoneControlBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox3.BorderRadius = 10;
			this.siticoneControlBox3.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox3.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.Location = new global::System.Drawing.Point(184, 12);
			this.siticoneControlBox3.Name = "siticoneControlBox3";
			this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.Size = new global::System.Drawing.Size(28, 27);
			this.siticoneControlBox3.TabIndex = 58;
			this.siticoneControlBox3.Click += new global::System.EventHandler(this.siticoneControlBox3_Click);
			this.siticoneControlBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox4.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox4.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox4.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox4.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox4.HoveredState.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox4.Location = new global::System.Drawing.Point(215, 12);
			this.siticoneControlBox4.Name = "siticoneControlBox4";
			this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.Size = new global::System.Drawing.Size(28, 27);
			this.siticoneControlBox4.TabIndex = 57;
			this.siticoneControlBox4.Click += new global::System.EventHandler(this.siticoneControlBox4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(250, 427);
			base.Controls.Add(this.siticoneControlBox3);
			base.Controls.Add(this.siticoneControlBox4);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.key);
			base.Controls.Add(this.status);
			base.Controls.Add(this.LicBtn);
			base.Controls.Add(this.UpgradeBtn);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			this.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ForsaSpoofer";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005D RID: 93
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005E RID: 94
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400005F RID: 95
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000060 RID: 96
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000061 RID: 97
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000063 RID: 99
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;

		// Token: 0x04000064 RID: 100
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000065 RID: 101
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

		// Token: 0x04000066 RID: 102
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

		// Token: 0x04000067 RID: 103
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LicBtn;

		// Token: 0x04000068 RID: 104
		private global::Siticone.UI.WinForms.SiticoneRoundedButton UpgradeBtn;

		// Token: 0x04000069 RID: 105
		private global::Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;

		// Token: 0x0400006A RID: 106
		private global::Siticone.UI.WinForms.SiticoneLabel status;

		// Token: 0x0400006B RID: 107
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox key;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000071 RID: 113
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x04000072 RID: 114
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox4;
	}
}
