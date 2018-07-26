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
			this.tabUser = new System.Windows.Forms.TabControl();
			this.tabUsers = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panBottomStrip = new System.Windows.Forms.Panel();
			this.btCancel = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFreq = new System.Windows.Forms.TextBox();
			this.tabUser.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panBottomStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabUser
			// 
			this.tabUser.AllowDrop = true;
			this.tabUser.Controls.Add(this.tabUsers);
			this.tabUser.Controls.Add(this.tabPage2);
			this.tabUser.Controls.Add(this.tabPage1);
			this.tabUser.Controls.Add(this.tabPage3);
			this.tabUser.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabUser.Location = new System.Drawing.Point(0, 0);
			this.tabUser.Name = "tabUser";
			this.tabUser.SelectedIndex = 0;
			this.tabUser.Size = new System.Drawing.Size(800, 384);
			this.tabUser.TabIndex = 0;
			// 
			// tabUsers
			// 
			this.tabUsers.Location = new System.Drawing.Point(4, 22);
			this.tabUsers.Name = "tabUsers";
			this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
			this.tabUsers.Size = new System.Drawing.Size(792, 358);
			this.tabUsers.TabIndex = 0;
			this.tabUsers.Text = "User Management";
			this.tabUsers.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 358);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Project Management";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 358);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Work types Management";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tbFreq);
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(792, 358);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "Settings";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// panBottomStrip
			// 
			this.panBottomStrip.Controls.Add(this.btCancel);
			this.panBottomStrip.Controls.Add(this.btOK);
			this.panBottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panBottomStrip.Location = new System.Drawing.Point(0, 390);
			this.panBottomStrip.Name = "panBottomStrip";
			this.panBottomStrip.Size = new System.Drawing.Size(800, 60);
			this.panBottomStrip.TabIndex = 1;
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(616, 25);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 23);
			this.btCancel.TabIndex = 1;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(713, 25);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 23);
			this.btOK.TabIndex = 0;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// tbFreq
			// 
			this.tbFreq.Location = new System.Drawing.Point(177, 27);
			this.tbFreq.Name = "tbFreq";
			this.tbFreq.Size = new System.Drawing.Size(100, 20);
			this.tbFreq.TabIndex = 1;
			// 
			// AdminDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panBottomStrip);
			this.Controls.Add(this.tabUser);
			this.Name = "AdminDashboardForm";
			this.Text = "AdminDashboardForm";
			this.tabUser.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.panBottomStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabUser;
		private System.Windows.Forms.TabPage tabUsers;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panBottomStrip;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox tbFreq;
		private System.Windows.Forms.Label label1;
	}
}