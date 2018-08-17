namespace timetracker
{
	partial class AdminDashboardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listboxUsers = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.btOpenStats = new System.Windows.Forms.Button();
            this.btOpenDir = new System.Windows.Forms.Button();
            this.tbUserIRDNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserGSTNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUserAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUserFullName = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.cbUserIsAdmin = new System.Windows.Forms.CheckBox();
            this.cbUserEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUserSave = new System.Windows.Forms.Button();
            this.btUserCancel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listboxProjects = new System.Windows.Forms.ListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAddProject = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveProject = new System.Windows.Forms.ToolStripButton();
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listboxWorktypes = new System.Windows.Forms.ListBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbAddWorktype = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveWorktype = new System.Windows.Forms.ToolStripButton();
            this.gbWorkType = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbMouseInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKBInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panBottomStrip = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveUrl = new System.Windows.Forms.Button();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.ChkLBoxUrls = new System.Windows.Forms.CheckedListBox();
            this.grpBoxProcesses = new System.Windows.Forms.GroupBox();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.ChkLBoxProcesses = new System.Windows.Forms.CheckedListBox();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panBottomStrip.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.AllowDrop = true;
            this.tabs.Controls.Add(this.tabUsers);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(630, 325);
            this.tabs.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tableLayoutPanel1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(622, 299);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "User Management";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.70482F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.29518F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listboxUsers);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 287);
            this.panel1.TabIndex = 0;
            // 
            // listboxUsers
            // 
            this.listboxUsers.DisplayMember = "Login";
            this.listboxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxUsers.FormattingEnabled = true;
            this.listboxUsers.Location = new System.Drawing.Point(0, 25);
            this.listboxUsers.Name = "listboxUsers";
            this.listboxUsers.Size = new System.Drawing.Size(232, 262);
            this.listboxUsers.TabIndex = 1;
            this.listboxUsers.ValueMember = "Id";
            this.listboxUsers.SelectedIndexChanged += new System.EventHandler(this.listboxUsers_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddUser,
            this.tsbRemoveUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(232, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddUser
            // 
            this.tsbAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddUser.Image = global::timetracker.Properties.Resources.Add_grey_16x;
            this.tsbAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddUser.Name = "tsbAddUser";
            this.tsbAddUser.Size = new System.Drawing.Size(23, 22);
            this.tsbAddUser.Text = "toolStripButton1";
            this.tsbAddUser.Click += new System.EventHandler(this.tsbAddUser_Click);
            // 
            // tsbRemoveUser
            // 
            this.tsbRemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveUser.Image = global::timetracker.Properties.Resources.Remove_16x;
            this.tsbRemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveUser.Name = "tsbRemoveUser";
            this.tsbRemoveUser.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveUser.Text = "toolStripButton2";
            this.tsbRemoveUser.Click += new System.EventHandler(this.tsbRemoveUser_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gbUser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(241, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(372, 287);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btOpenStats);
            this.gbUser.Controls.Add(this.btOpenDir);
            this.gbUser.Controls.Add(this.tbUserIRDNumber);
            this.gbUser.Controls.Add(this.label9);
            this.gbUser.Controls.Add(this.tbUserGSTNumber);
            this.gbUser.Controls.Add(this.label8);
            this.gbUser.Controls.Add(this.tbUserAddress);
            this.gbUser.Controls.Add(this.label7);
            this.gbUser.Controls.Add(this.tbUserFullName);
            this.gbUser.Controls.Add(this.tbUserPassword);
            this.gbUser.Controls.Add(this.tbUserLogin);
            this.gbUser.Controls.Add(this.cbUserIsAdmin);
            this.gbUser.Controls.Add(this.cbUserEnabled);
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUser.Enabled = false;
            this.gbUser.Location = new System.Drawing.Point(3, 3);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(366, 235);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User Properties";
            // 
            // btOpenStats
            // 
            this.btOpenStats.Location = new System.Drawing.Point(166, 233);
            this.btOpenStats.Name = "btOpenStats";
            this.btOpenStats.Size = new System.Drawing.Size(86, 23);
            this.btOpenStats.TabIndex = 16;
            this.btOpenStats.Text = "Statistics...";
            this.btOpenStats.UseVisualStyleBackColor = true;
            this.btOpenStats.Click += new System.EventHandler(this.btOpenStats_Click);
            // 
            // btOpenDir
            // 
            this.btOpenDir.Location = new System.Drawing.Point(258, 233);
            this.btOpenDir.Name = "btOpenDir";
            this.btOpenDir.Size = new System.Drawing.Size(86, 23);
            this.btOpenDir.TabIndex = 15;
            this.btOpenDir.Text = "Screenshots...";
            this.btOpenDir.UseVisualStyleBackColor = true;
            this.btOpenDir.Click += new System.EventHandler(this.btOpenDir_Click);
            // 
            // tbUserIRDNumber
            // 
            this.tbUserIRDNumber.Location = new System.Drawing.Point(92, 183);
            this.tbUserIRDNumber.Name = "tbUserIRDNumber";
            this.tbUserIRDNumber.Size = new System.Drawing.Size(252, 20);
            this.tbUserIRDNumber.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "IRD Number";
            // 
            // tbUserGSTNumber
            // 
            this.tbUserGSTNumber.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbUserGSTNumber.Location = new System.Drawing.Point(92, 153);
            this.tbUserGSTNumber.Name = "tbUserGSTNumber";
            this.tbUserGSTNumber.Size = new System.Drawing.Size(252, 20);
            this.tbUserGSTNumber.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "GST Number";
            // 
            // tbUserAddress
            // 
            this.tbUserAddress.Location = new System.Drawing.Point(92, 124);
            this.tbUserAddress.Name = "tbUserAddress";
            this.tbUserAddress.Size = new System.Drawing.Size(252, 20);
            this.tbUserAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            // 
            // tbUserFullName
            // 
            this.tbUserFullName.Location = new System.Drawing.Point(93, 79);
            this.tbUserFullName.Name = "tbUserFullName";
            this.tbUserFullName.Size = new System.Drawing.Size(252, 20);
            this.tbUserFullName.TabIndex = 7;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(93, 50);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '*';
            this.tbUserPassword.Size = new System.Drawing.Size(252, 20);
            this.tbUserPassword.TabIndex = 6;
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Location = new System.Drawing.Point(93, 22);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(252, 20);
            this.tbUserLogin.TabIndex = 5;
            // 
            // cbUserIsAdmin
            // 
            this.cbUserIsAdmin.AutoSize = true;
            this.cbUserIsAdmin.Location = new System.Drawing.Point(6, 239);
            this.cbUserIsAdmin.Name = "cbUserIsAdmin";
            this.cbUserIsAdmin.Size = new System.Drawing.Size(72, 17);
            this.cbUserIsAdmin.TabIndex = 4;
            this.cbUserIsAdmin.Text = "Is Admin?";
            this.cbUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // cbUserEnabled
            // 
            this.cbUserEnabled.AutoSize = true;
            this.cbUserEnabled.Location = new System.Drawing.Point(6, 215);
            this.cbUserEnabled.Name = "cbUserEnabled";
            this.cbUserEnabled.Size = new System.Drawing.Size(71, 17);
            this.cbUserEnabled.TabIndex = 3;
            this.cbUserEnabled.Text = "Enabled?";
            this.cbUserEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUserSave);
            this.flowLayoutPanel1.Controls.Add(this.btUserCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 241);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 46);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btUserSave
            // 
            this.btUserSave.Location = new System.Drawing.Point(286, 11);
            this.btUserSave.Name = "btUserSave";
            this.btUserSave.Size = new System.Drawing.Size(75, 23);
            this.btUserSave.TabIndex = 14;
            this.btUserSave.Text = "Save";
            this.btUserSave.UseVisualStyleBackColor = true;
            this.btUserSave.Click += new System.EventHandler(this.btUserSave_Click);
            // 
            // btUserCancel
            // 
            this.btUserCancel.Location = new System.Drawing.Point(205, 11);
            this.btUserCancel.Name = "btUserCancel";
            this.btUserCancel.Size = new System.Drawing.Size(75, 23);
            this.btUserCancel.TabIndex = 13;
            this.btUserCancel.Text = "Cancel";
            this.btUserCancel.UseVisualStyleBackColor = true;
            this.btUserCancel.Click += new System.EventHandler(this.btUserCancel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Project Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.70482F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.29518F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbProject, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 293);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listboxProjects);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 287);
            this.panel2.TabIndex = 0;
            // 
            // listboxProjects
            // 
            this.listboxProjects.DisplayMember = "Name";
            this.listboxProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxProjects.FormattingEnabled = true;
            this.listboxProjects.Location = new System.Drawing.Point(0, 25);
            this.listboxProjects.Name = "listboxProjects";
            this.listboxProjects.Size = new System.Drawing.Size(232, 262);
            this.listboxProjects.TabIndex = 1;
            this.listboxProjects.ValueMember = "Id";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddProject,
            this.tsbRemoveProject});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(232, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAddProject
            // 
            this.tsbAddProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddProject.Image = global::timetracker.Properties.Resources.Add_grey_16x;
            this.tsbAddProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddProject.Name = "tsbAddProject";
            this.tsbAddProject.Size = new System.Drawing.Size(23, 22);
            this.tsbAddProject.Text = "toolStripButton1";
            this.tsbAddProject.Click += new System.EventHandler(this.tsbAddProject_Click);
            // 
            // tsbRemoveProject
            // 
            this.tsbRemoveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveProject.Image = global::timetracker.Properties.Resources.Remove_16x;
            this.tsbRemoveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveProject.Name = "tsbRemoveProject";
            this.tsbRemoveProject.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveProject.Text = "toolStripButton2";
            // 
            // gbProject
            // 
            this.gbProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProject.Location = new System.Drawing.Point(241, 3);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(372, 287);
            this.gbProject.TabIndex = 1;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Project Properties";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 299);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Work types Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.70482F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.29518F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbWorkType, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 293);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listboxWorktypes);
            this.panel3.Controls.Add(this.toolStrip3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 287);
            this.panel3.TabIndex = 0;
            // 
            // listboxWorktypes
            // 
            this.listboxWorktypes.DisplayMember = "Name";
            this.listboxWorktypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxWorktypes.FormattingEnabled = true;
            this.listboxWorktypes.Location = new System.Drawing.Point(0, 25);
            this.listboxWorktypes.Name = "listboxWorktypes";
            this.listboxWorktypes.Size = new System.Drawing.Size(232, 262);
            this.listboxWorktypes.TabIndex = 1;
            this.listboxWorktypes.ValueMember = "Id";
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddWorktype,
            this.tsbRemoveWorktype});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(232, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbAddWorktype
            // 
            this.tsbAddWorktype.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddWorktype.Image = global::timetracker.Properties.Resources.Add_grey_16x;
            this.tsbAddWorktype.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddWorktype.Name = "tsbAddWorktype";
            this.tsbAddWorktype.Size = new System.Drawing.Size(23, 22);
            this.tsbAddWorktype.Text = "toolStripButton1";
            this.tsbAddWorktype.Click += new System.EventHandler(this.tsbAddWorktype_Click);
            // 
            // tsbRemoveWorktype
            // 
            this.tsbRemoveWorktype.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveWorktype.Image = global::timetracker.Properties.Resources.Remove_16x;
            this.tsbRemoveWorktype.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveWorktype.Name = "tsbRemoveWorktype";
            this.tsbRemoveWorktype.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveWorktype.Text = "toolStripButton2";
            // 
            // gbWorkType
            // 
            this.gbWorkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWorkType.Location = new System.Drawing.Point(241, 3);
            this.gbWorkType.Name = "gbWorkType";
            this.gbWorkType.Size = new System.Drawing.Size(372, 287);
            this.gbWorkType.TabIndex = 1;
            this.gbWorkType.TabStop = false;
            this.gbWorkType.Text = "Work Type Properties";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbMouseInterval);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbKBInterval);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.panBottomStrip);
            this.tabPage3.Controls.Add(this.tbFreq);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(622, 299);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbMouseInterval
            // 
            this.tbMouseInterval.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbMouseInterval.Location = new System.Drawing.Point(161, 82);
            this.tbMouseInterval.Name = "tbMouseInterval";
            this.tbMouseInterval.Size = new System.Drawing.Size(100, 20);
            this.tbMouseInterval.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max Mouse Interval (s)";
            // 
            // tbKBInterval
            // 
            this.tbKBInterval.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbKBInterval.Location = new System.Drawing.Point(161, 45);
            this.tbKBInterval.Name = "tbKBInterval";
            this.tbKBInterval.Size = new System.Drawing.Size(100, 20);
            this.tbKBInterval.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max Keyboard Interval (s)";
            // 
            // panBottomStrip
            // 
            this.panBottomStrip.Controls.Add(this.btCancel);
            this.panBottomStrip.Controls.Add(this.btOK);
            this.panBottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottomStrip.Location = new System.Drawing.Point(3, 266);
            this.panBottomStrip.Name = "panBottomStrip";
            this.panBottomStrip.Size = new System.Drawing.Size(616, 30);
            this.panBottomStrip.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Dismis";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(84, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "Apply";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbFreq
            // 
            this.tbFreq.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbFreq.Location = new System.Drawing.Point(161, 12);
            this.tbFreq.Name = "tbFreq";
            this.tbFreq.Size = new System.Drawing.Size(100, 20);
            this.tbFreq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screenshoting Frequency (s)";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.grpBoxProcesses);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(622, 299);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Alowed processes and URLS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(357, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 285);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FAQ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(6, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 262);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveUrl);
            this.groupBox1.Controls.Add(this.btnAddUrl);
            this.groupBox1.Controls.Add(this.ChkLBoxUrls);
            this.groupBox1.Location = new System.Drawing.Point(182, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 285);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urls";
            // 
            // btnRemoveUrl
            // 
            this.btnRemoveUrl.Image = global::timetracker.Properties.Resources.Remove_16x;
            this.btnRemoveUrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUrl.Location = new System.Drawing.Point(37, 256);
            this.btnRemoveUrl.Name = "btnRemoveUrl";
            this.btnRemoveUrl.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveUrl.TabIndex = 15;
            this.btnRemoveUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveUrl.UseVisualStyleBackColor = true;
            this.btnRemoveUrl.Click += new System.EventHandler(this.btnRemoveUrl_Click);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Image = global::timetracker.Properties.Resources.Add_grey_16x;
            this.btnAddUrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUrl.Location = new System.Drawing.Point(6, 256);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(25, 23);
            this.btnAddUrl.TabIndex = 13;
            this.btnAddUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // ChkLBoxUrls
            // 
            this.ChkLBoxUrls.FormattingEnabled = true;
            this.ChkLBoxUrls.Location = new System.Drawing.Point(6, 17);
            this.ChkLBoxUrls.Name = "ChkLBoxUrls";
            this.ChkLBoxUrls.Size = new System.Drawing.Size(157, 229);
            this.ChkLBoxUrls.TabIndex = 12;
            this.ChkLBoxUrls.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkLBoxUrls_ItemCheck);
            // 
            // grpBoxProcesses
            // 
            this.grpBoxProcesses.Controls.Add(this.btnRemoveProcess);
            this.grpBoxProcesses.Controls.Add(this.ChkLBoxProcesses);
            this.grpBoxProcesses.Controls.Add(this.btnAddProcess);
            this.grpBoxProcesses.Location = new System.Drawing.Point(5, 8);
            this.grpBoxProcesses.Name = "grpBoxProcesses";
            this.grpBoxProcesses.Size = new System.Drawing.Size(169, 285);
            this.grpBoxProcesses.TabIndex = 17;
            this.grpBoxProcesses.TabStop = false;
            this.grpBoxProcesses.Text = "Processes";
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.Image = global::timetracker.Properties.Resources.Remove_16x;
            this.btnRemoveProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveProcess.Location = new System.Drawing.Point(37, 256);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveProcess.TabIndex = 14;
            this.btnRemoveProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveProcess.UseVisualStyleBackColor = true;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // ChkLBoxProcesses
            // 
            this.ChkLBoxProcesses.FormattingEnabled = true;
            this.ChkLBoxProcesses.Location = new System.Drawing.Point(6, 17);
            this.ChkLBoxProcesses.Name = "ChkLBoxProcesses";
            this.ChkLBoxProcesses.Size = new System.Drawing.Size(157, 229);
            this.ChkLBoxProcesses.TabIndex = 11;
            this.ChkLBoxProcesses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkLBoxProcesses_ItemCheck);
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Image = global::timetracker.Properties.Resources.Add_grey_16x;
            this.btnAddProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProcess.Location = new System.Drawing.Point(6, 256);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(25, 23);
            this.btnAddProcess.TabIndex = 13;
            this.btnAddProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 325);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panBottomStrip.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxProcesses.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabUsers;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox tbFreq;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listboxUsers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddUser;
        private System.Windows.Forms.ToolStripButton tsbRemoveUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listboxProjects;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAddProject;
        private System.Windows.Forms.ToolStripButton tsbRemoveProject;
        private System.Windows.Forms.GroupBox gbProject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listboxWorktypes;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbAddWorktype;
        private System.Windows.Forms.ToolStripButton tsbRemoveWorktype;
        private System.Windows.Forms.GroupBox gbWorkType;
        private System.Windows.Forms.Panel panBottomStrip;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox tbUserFullName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.CheckBox cbUserIsAdmin;
        private System.Windows.Forms.CheckBox cbUserEnabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btUserSave;
        private System.Windows.Forms.Button btUserCancel;
		private System.Windows.Forms.TextBox tbKBInterval;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbMouseInterval;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserIRDNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUserGSTNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUserAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.CheckedListBox ChkLBoxUrls;
        private System.Windows.Forms.GroupBox grpBoxProcesses;
        private System.Windows.Forms.CheckedListBox ChkLBoxProcesses;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnRemoveUrl;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btOpenDir;
        private System.Windows.Forms.Button btOpenStats;
    }
}