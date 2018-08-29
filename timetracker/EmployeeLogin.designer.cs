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
			this.label3 = new System.Windows.Forms.Label();
			this.btRegister = new System.Windows.Forms.Button();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(135, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 19);
			this.label3.TabIndex = 18;
			this.label3.Text = "MEMBER LOGIN";
			// 
			// btRegister
			// 
			this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRegister.Location = new System.Drawing.Point(204, 180);
			this.btRegister.Name = "btRegister";
			this.btRegister.Size = new System.Drawing.Size(75, 33);
			this.btRegister.TabIndex = 17;
			this.btRegister.Text = "Register";
			this.btRegister.UseVisualStyleBackColor = true;
			this.btRegister.Click += new System.EventHandler(this.btRegister_Click_1);
			// 
			// tbLogin
			// 
			this.tbLogin.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tbLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLogin.Location = new System.Drawing.Point(95, 61);
			this.tbLogin.Multiline = true;
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(220, 27);
			this.tbLogin.TabIndex = 13;
			this.tbLogin.Text = "Username";
			this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
			this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
			// 
			// tbPassword
			// 
			this.tbPassword.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(95, 130);
			this.tbPassword.Multiline = true;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(220, 27);
			this.tbPassword.TabIndex = 14;
			this.tbPassword.Tag = "";
			this.tbPassword.Text = "Password";
			this.tbPassword.UseWaitCursor = true;
			this.tbPassword.WordWrap = false;
			this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
			// 
			// btLogin
			// 
			this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogin.Location = new System.Drawing.Point(106, 180);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(82, 33);
			this.btLogin.TabIndex = 15;
			this.btLogin.Text = "Login";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click_1);
			// 
			// EmployeeLogin
			// 
			this.AcceptButton = this.btLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.BackgroundImage = global::timetracker.Properties.Resources.abstract_abstract_expressionism_abstract_painting_1143770;
			this.ClientSize = new System.Drawing.Size(398, 239);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btRegister);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.btLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmployeeLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.EmployeeLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btRegister;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btLogin;
	}
}