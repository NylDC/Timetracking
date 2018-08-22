namespace timetracker
{
	partial class EmployeeLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btLogin = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.btRegister = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbLogin
			// 
			this.tbLogin.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tbLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLogin.Location = new System.Drawing.Point(70, 74);
			this.tbLogin.Multiline = true;
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(208, 28);
			this.tbLogin.TabIndex = 0;
			this.tbLogin.Text = "USERNAME";
			// 
			// tbPassword
			// 
			this.tbPassword.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(70, 159);
			this.tbPassword.Multiline = true;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(208, 26);
			this.tbPassword.TabIndex = 1;
			this.tbPassword.Tag = "";
			this.tbPassword.Text = "PASSWORD";
			this.tbPassword.UseWaitCursor = true;
			this.tbPassword.WordWrap = false;
			// 
			// btLogin
			// 
			this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLogin.Location = new System.Drawing.Point(6, 213);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(82, 26);
			this.btLogin.TabIndex = 2;
			this.btLogin.Text = "Login";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// btExit
			// 
			this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btExit.Location = new System.Drawing.Point(196, 213);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(82, 26);
			this.btExit.TabIndex = 7;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btRegister
			// 
			this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btRegister.Location = new System.Drawing.Point(104, 213);
			this.btRegister.Name = "btRegister";
			this.btRegister.Size = new System.Drawing.Size(75, 26);
			this.btRegister.TabIndex = 9;
			this.btRegister.Text = "Register";
			this.btRegister.UseVisualStyleBackColor = true;
			this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btRegister);
			this.panel1.Controls.Add(this.tbLogin);
			this.panel1.Controls.Add(this.tbPassword);
			this.panel1.Controls.Add(this.btExit);
			this.panel1.Controls.Add(this.btLogin);
			this.panel1.Location = new System.Drawing.Point(43, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(308, 275);
			this.panel1.TabIndex = 10;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
			this.pictureBox2.ErrorImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(35, 74);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(39, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(35, 159);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(101, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "MEMBER LOGIN";
			this.label3.Click += new System.EventHandler(this.label3_Click_1);
			// 
			// EmployeeLogin
			// 
			this.AcceptButton = this.btLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.CancelButton = this.btExit;
			this.ClientSize = new System.Drawing.Size(392, 344);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmployeeLogin";
			this.Load += new System.EventHandler(this.EmployeeLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.Button btRegister;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}