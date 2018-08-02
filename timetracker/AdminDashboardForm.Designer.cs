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
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listboxUsers = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new timetracker.databaseDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listboxProjects = new System.Windows.Forms.ListBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAddProject = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveProject = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listboxWorktypes = new System.Windows.Forms.ListBox();
            this.workTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbAddWorktype = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveWorktype = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDataSet = new timetracker.databaseDataSet();
            this.usersTableAdapter = new timetracker.databaseDataSetTableAdapters.UsersTableAdapter();
            this.workTypesTableAdapter = new timetracker.databaseDataSetTableAdapters.WorkTypesTableAdapter();
            this.projectsTableAdapter = new timetracker.databaseDataSetTableAdapters.ProjectsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUserEnabled = new System.Windows.Forms.CheckBox();
            this.cbUserIsAdmin = new System.Windows.Forms.CheckBox();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserFullName = new System.Windows.Forms.TextBox();
            this.panBottomStrip = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btUserSave = new System.Windows.Forms.Button();
            this.btUserCancel = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTypesBindingSource)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panBottomStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.AllowDrop = true;
            this.tabs.Controls.Add(this.tabUsers);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(605, 411);
            this.tabs.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tableLayoutPanel1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(597, 385);
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
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listboxUsers);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 373);
            this.panel1.TabIndex = 0;
            // 
            // listboxUsers
            // 
            this.listboxUsers.DataSource = this.usersBindingSource;
            this.listboxUsers.DisplayMember = "FullName";
            this.listboxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxUsers.FormattingEnabled = true;
            this.listboxUsers.Location = new System.Drawing.Point(0, 25);
            this.listboxUsers.Name = "listboxUsers";
            this.listboxUsers.Size = new System.Drawing.Size(222, 348);
            this.listboxUsers.TabIndex = 1;
            this.listboxUsers.ValueMember = "Id";
            this.listboxUsers.SelectedIndexChanged += new System.EventHandler(this.listboxUsers_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddUser,
            this.tsbRemoveUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(222, 25);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUserCancel);
            this.groupBox1.Controls.Add(this.btUserSave);
            this.groupBox1.Controls.Add(this.tbUserFullName);
            this.groupBox1.Controls.Add(this.tbUserPassword);
            this.groupBox1.Controls.Add(this.tbUserLogin);
            this.groupBox1.Controls.Add(this.cbUserIsAdmin);
            this.groupBox1.Controls.Add(this.cbUserEnabled);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(231, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Properties";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 343);
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
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 337);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listboxProjects);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 331);
            this.panel2.TabIndex = 0;
            // 
            // listboxProjects
            // 
            this.listboxProjects.DataSource = this.projectsBindingSource;
            this.listboxProjects.DisplayMember = "Name";
            this.listboxProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxProjects.FormattingEnabled = true;
            this.listboxProjects.Location = new System.Drawing.Point(0, 25);
            this.listboxProjects.Name = "listboxProjects";
            this.listboxProjects.Size = new System.Drawing.Size(250, 306);
            this.listboxProjects.TabIndex = 1;
            this.listboxProjects.ValueMember = "Id";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddProject,
            this.tsbRemoveProject});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(250, 25);
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
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(259, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Properties";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 343);
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
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(664, 337);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listboxWorktypes);
            this.panel3.Controls.Add(this.toolStrip3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 331);
            this.panel3.TabIndex = 0;
            // 
            // listboxWorktypes
            // 
            this.listboxWorktypes.DataSource = this.workTypesBindingSource;
            this.listboxWorktypes.DisplayMember = "Name";
            this.listboxWorktypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxWorktypes.FormattingEnabled = true;
            this.listboxWorktypes.Location = new System.Drawing.Point(0, 25);
            this.listboxWorktypes.Name = "listboxWorktypes";
            this.listboxWorktypes.Size = new System.Drawing.Size(250, 306);
            this.listboxWorktypes.TabIndex = 1;
            this.listboxWorktypes.ValueMember = "Id";
            // 
            // workTypesBindingSource
            // 
            this.workTypesBindingSource.DataMember = "WorkTypes";
            this.workTypesBindingSource.DataSource = this.databaseDataSet1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddWorktype,
            this.tsbRemoveWorktype});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(250, 25);
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
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(259, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 331);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Properties";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panBottomStrip);
            this.tabPage3.Controls.Add(this.tbFreq);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(597, 343);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbFreq
            // 
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
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // workTypesTableAdapter
            // 
            this.workTypesTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
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
            // cbUserEnabled
            // 
            this.cbUserEnabled.AutoSize = true;
            this.cbUserEnabled.Location = new System.Drawing.Point(7, 112);
            this.cbUserEnabled.Name = "cbUserEnabled";
            this.cbUserEnabled.Size = new System.Drawing.Size(71, 17);
            this.cbUserEnabled.TabIndex = 3;
            this.cbUserEnabled.Text = "Enabled?";
            this.cbUserEnabled.UseVisualStyleBackColor = true;
            // 
            // cbUserIsAdmin
            // 
            this.cbUserIsAdmin.AutoSize = true;
            this.cbUserIsAdmin.Location = new System.Drawing.Point(7, 136);
            this.cbUserIsAdmin.Name = "cbUserIsAdmin";
            this.cbUserIsAdmin.Size = new System.Drawing.Size(72, 17);
            this.cbUserIsAdmin.TabIndex = 4;
            this.cbUserIsAdmin.Text = "Is Admin?";
            this.cbUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Location = new System.Drawing.Point(93, 22);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(252, 20);
            this.tbUserLogin.TabIndex = 5;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(93, 50);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(252, 20);
            this.tbUserPassword.TabIndex = 6;
            // 
            // tbUserFullName
            // 
            this.tbUserFullName.Location = new System.Drawing.Point(93, 79);
            this.tbUserFullName.Name = "tbUserFullName";
            this.tbUserFullName.Size = new System.Drawing.Size(252, 20);
            this.tbUserFullName.TabIndex = 7;
            // 
            // panBottomStrip
            // 
            this.panBottomStrip.Controls.Add(this.btCancel);
            this.panBottomStrip.Controls.Add(this.btOK);
            this.panBottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottomStrip.Location = new System.Drawing.Point(3, 271);
            this.panBottomStrip.Name = "panBottomStrip";
            this.panBottomStrip.Size = new System.Drawing.Size(591, 69);
            this.panBottomStrip.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(373, 25);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(497, 25);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btUserSave
            // 
            this.btUserSave.Location = new System.Drawing.Point(170, 187);
            this.btUserSave.Name = "btUserSave";
            this.btUserSave.Size = new System.Drawing.Size(75, 23);
            this.btUserSave.TabIndex = 8;
            this.btUserSave.Text = "Save";
            this.btUserSave.UseVisualStyleBackColor = true;
            // 
            // btUserCancel
            // 
            this.btUserCancel.Location = new System.Drawing.Point(270, 187);
            this.btUserCancel.Name = "btUserCancel";
            this.btUserCancel.Size = new System.Drawing.Size(75, 23);
            this.btUserCancel.TabIndex = 9;
            this.btUserCancel.Text = "Cancel";
            this.btUserCancel.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 411);
            this.Controls.Add(this.tabs);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTypesBindingSource)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panBottomStrip.ResumeLayout(false);
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
        private databaseDataSet databaseDataSet;
        private databaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listboxUsers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddUser;
        private System.Windows.Forms.ToolStripButton tsbRemoveUser;
        private databaseDataSet databaseDataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listboxProjects;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAddProject;
        private System.Windows.Forms.ToolStripButton tsbRemoveProject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listboxWorktypes;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbAddWorktype;
        private System.Windows.Forms.ToolStripButton tsbRemoveWorktype;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource workTypesBindingSource;
        private databaseDataSetTableAdapters.WorkTypesTableAdapter workTypesTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private databaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserFullName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.CheckBox cbUserIsAdmin;
        private System.Windows.Forms.CheckBox cbUserEnabled;
        private System.Windows.Forms.Panel panBottomStrip;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btUserCancel;
        private System.Windows.Forms.Button btUserSave;
    }
}