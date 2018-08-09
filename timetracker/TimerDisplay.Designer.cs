namespace timetracker
{
    partial class TimerDisplay
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
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btStop = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.cbWorkTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWorks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.41222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.58779F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 109);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(3, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(227, 72);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btStop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btResume, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btStart, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 31);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btStop
            // 
            this.btStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(153, 3);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(71, 25);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btResume
            // 
            this.btResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btResume.Enabled = false;
            this.btResume.Location = new System.Drawing.Point(78, 3);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(69, 25);
            this.btResume.TabIndex = 4;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btStart
            // 
            this.btStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStart.Location = new System.Drawing.Point(3, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(69, 25);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project";
            // 
            // cbProjects
            // 
            this.cbProjects.DisplayMember = "Name";
            this.cbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(12, 25);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(209, 21);
            this.cbProjects.TabIndex = 7;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // cbWorkTypes
            // 
            this.cbWorkTypes.DisplayMember = "Name";
            this.cbWorkTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkTypes.FormattingEnabled = true;
            this.cbWorkTypes.Location = new System.Drawing.Point(12, 71);
            this.cbWorkTypes.Name = "cbWorkTypes";
            this.cbWorkTypes.Size = new System.Drawing.Size(209, 21);
            this.cbWorkTypes.TabIndex = 9;
            this.cbWorkTypes.SelectedIndexChanged += new System.EventHandler(this.cbWorkTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Work Type";
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "FullName";
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(12, 116);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(209, 21);
            this.cbUser.TabIndex = 11;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "User";
            // 
            // cbWorks
            // 
            this.cbWorks.DisplayMember = "VisibleTitle";
            this.cbWorks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorks.FormattingEnabled = true;
            this.cbWorks.ItemHeight = 13;
            this.cbWorks.Location = new System.Drawing.Point(13, 162);
            this.cbWorks.Name = "cbWorks";
            this.cbWorks.Size = new System.Drawing.Size(208, 21);
            this.cbWorks.TabIndex = 12;
            this.cbWorks.SelectedIndexChanged += new System.EventHandler(this.cbWorks_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Work";
            // 
            // TimerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 314);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbWorks);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbWorkTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimerDisplay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TimerDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.ComboBox cbWorkTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWorks;
        private System.Windows.Forms.Label label5;
    }
}