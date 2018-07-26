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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabUsers = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panBottomStrip = new System.Windows.Forms.Panel();
			this.btOK = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.panBottomStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabUsers);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 384);
			this.tabControl1.TabIndex = 0;
			// 
			// tabUsers
			// 
			this.tabUsers.Location = new System.Drawing.Point(4, 22);
			this.tabUsers.Name = "tabUsers";
			this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
			this.tabUsers.Size = new System.Drawing.Size(792, 358);
			this.tabUsers.TabIndex = 0;
			this.tabUsers.Text = "tabPage1";
			this.tabUsers.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 358);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panBottomStrip
			// 
			this.panBottomStrip.Controls.Add(this.btOK);
			this.panBottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panBottomStrip.Location = new System.Drawing.Point(0, 390);
			this.panBottomStrip.Name = "panBottomStrip";
			this.panBottomStrip.Size = new System.Drawing.Size(800, 60);
			this.panBottomStrip.TabIndex = 1;
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
			// AdminDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panBottomStrip);
			this.Controls.Add(this.tabControl1);
			this.Name = "AdminDashboardForm";
			this.Text = "AdminDashboardForm";
			this.tabControl1.ResumeLayout(false);
			this.panBottomStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabUsers;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panBottomStrip;
		private System.Windows.Forms.Button btOK;
	}
}