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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerDisplay));
            this.panTimeControl = new System.Windows.Forms.TableLayoutPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.panTimeControls = new System.Windows.Forms.TableLayoutPanel();
            this.btStop = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.cbWorkTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWorks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGreeting = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btEditWork = new System.Windows.Forms.Button();
            this.panEditName = new System.Windows.Forms.FlowLayoutPanel();
            this.tbWorkName = new System.Windows.Forms.TextBox();
            this.btEditWorkSave = new System.Windows.Forms.Button();
            this.btWorkNoSave = new System.Windows.Forms.Button();
            this.panTimeControl.SuspendLayout();
            this.panTimeControls.SuspendLayout();
            this.panEditName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTimeControl
            // 
            this.panTimeControl.ColumnCount = 1;
            this.panTimeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panTimeControl.Controls.Add(this.lbTime, 0, 0);
            this.panTimeControl.Controls.Add(this.panTimeControls, 0, 1);
            this.panTimeControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panTimeControl.Location = new System.Drawing.Point(0, 181);
            this.panTimeControl.Name = "panTimeControl";
            this.panTimeControl.RowCount = 2;
            this.panTimeControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.41222F));
            this.panTimeControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.58779F));
            this.panTimeControl.Size = new System.Drawing.Size(233, 109);
            this.panTimeControl.TabIndex = 5;
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
            // panTimeControls
            // 
            this.panTimeControls.ColumnCount = 3;
            this.panTimeControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panTimeControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panTimeControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panTimeControls.Controls.Add(this.btStop, 0, 0);
            this.panTimeControls.Controls.Add(this.btResume, 0, 0);
            this.panTimeControls.Controls.Add(this.btStart, 0, 0);
            this.panTimeControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTimeControls.Location = new System.Drawing.Point(3, 75);
            this.panTimeControls.Name = "panTimeControls";
            this.panTimeControls.RowCount = 1;
            this.panTimeControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panTimeControls.Size = new System.Drawing.Size(227, 31);
            this.panTimeControls.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(9, 39);
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
            this.cbProjects.Location = new System.Drawing.Point(6, 55);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(221, 21);
            this.cbProjects.TabIndex = 7;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // cbWorkTypes
            // 
            this.cbWorkTypes.DisplayMember = "Name";
            this.cbWorkTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkTypes.FormattingEnabled = true;
            this.cbWorkTypes.Location = new System.Drawing.Point(6, 101);
            this.cbWorkTypes.Name = "cbWorkTypes";
            this.cbWorkTypes.Size = new System.Drawing.Size(221, 21);
            this.cbWorkTypes.TabIndex = 9;
            this.cbWorkTypes.SelectedIndexChanged += new System.EventHandler(this.cbWorkTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Work Type";
            // 
            // cbWorks
            // 
            this.cbWorks.DisplayMember = "VisibleTitle";
            this.cbWorks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorks.FormattingEnabled = true;
            this.cbWorks.ItemHeight = 13;
            this.cbWorks.Location = new System.Drawing.Point(6, 146);
            this.cbWorks.Name = "cbWorks";
            this.cbWorks.Size = new System.Drawing.Size(194, 21);
            this.cbWorks.TabIndex = 12;
            this.cbWorks.SelectedIndexChanged += new System.EventHandler(this.cbWorks_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Work";
            // 
            // lbGreeting
            // 
            this.lbGreeting.AutoSize = true;
            this.lbGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreeting.Location = new System.Drawing.Point(8, 10);
            this.lbGreeting.Name = "lbGreeting";
            this.lbGreeting.Size = new System.Drawing.Size(52, 17);
            this.lbGreeting.TabIndex = 14;
            this.lbGreeting.Text = "label2";
            // 
            // btClose
            // 
            this.btClose.Image = global::timetracker.Properties.Resources.Close_16x;
            this.btClose.Location = new System.Drawing.Point(203, 6);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(24, 23);
            this.btClose.TabIndex = 15;
            this.btClose.TabStop = false;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btEditWork
            // 
            this.btEditWork.Image = ((System.Drawing.Image)(resources.GetObject("btEditWork.Image")));
            this.btEditWork.Location = new System.Drawing.Point(203, 145);
            this.btEditWork.Name = "btEditWork";
            this.btEditWork.Size = new System.Drawing.Size(24, 23);
            this.btEditWork.TabIndex = 16;
            this.btEditWork.TabStop = false;
            this.btEditWork.UseVisualStyleBackColor = true;
            this.btEditWork.Click += new System.EventHandler(this.btEditWork_Click);
            // 
            // panEditName
            // 
            this.panEditName.Controls.Add(this.tbWorkName);
            this.panEditName.Controls.Add(this.btEditWorkSave);
            this.panEditName.Controls.Add(this.btWorkNoSave);
            this.panEditName.Enabled = false;
            this.panEditName.Location = new System.Drawing.Point(0, 142);
            this.panEditName.Name = "panEditName";
            this.panEditName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panEditName.Size = new System.Drawing.Size(233, 29);
            this.panEditName.TabIndex = 19;
            this.panEditName.Visible = false;
            this.panEditName.WrapContents = false;
            // 
            // tbWorkName
            // 
            this.tbWorkName.Location = new System.Drawing.Point(6, 4);
            this.tbWorkName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.tbWorkName.Name = "tbWorkName";
            this.tbWorkName.Size = new System.Drawing.Size(162, 20);
            this.tbWorkName.TabIndex = 18;
            // 
            // btEditWorkSave
            // 
            this.btEditWorkSave.Image = ((System.Drawing.Image)(resources.GetObject("btEditWorkSave.Image")));
            this.btEditWorkSave.Location = new System.Drawing.Point(174, 3);
            this.btEditWorkSave.Name = "btEditWorkSave";
            this.btEditWorkSave.Size = new System.Drawing.Size(24, 23);
            this.btEditWorkSave.TabIndex = 19;
            this.btEditWorkSave.UseVisualStyleBackColor = true;
            this.btEditWorkSave.Click += new System.EventHandler(this.btEditWorkSave_Click);
            // 
            // btWorkNoSave
            // 
            this.btWorkNoSave.Image = global::timetracker.Properties.Resources.Close_red_16x;
            this.btWorkNoSave.Location = new System.Drawing.Point(204, 3);
            this.btWorkNoSave.Name = "btWorkNoSave";
            this.btWorkNoSave.Size = new System.Drawing.Size(24, 23);
            this.btWorkNoSave.TabIndex = 20;
            this.btWorkNoSave.UseVisualStyleBackColor = true;
            this.btWorkNoSave.Click += new System.EventHandler(this.btEditWorkNoSave_Click);
            // 
            // TimerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 290);
            this.ControlBox = false;
            this.Controls.Add(this.panEditName);
            this.Controls.Add(this.btEditWork);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbGreeting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbWorks);
            this.Controls.Add(this.cbWorkTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panTimeControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerDisplay_KeyPress);
            this.panTimeControl.ResumeLayout(false);
            this.panTimeControl.PerformLayout();
            this.panTimeControls.ResumeLayout(false);
            this.panEditName.ResumeLayout(false);
            this.panEditName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel panTimeControl;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TableLayoutPanel panTimeControls;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.ComboBox cbWorkTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbWorks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbGreeting;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btEditWork;
        private System.Windows.Forms.FlowLayoutPanel panEditName;
        private System.Windows.Forms.TextBox tbWorkName;
        private System.Windows.Forms.Button btEditWorkSave;
        private System.Windows.Forms.Button btWorkNoSave;
    }
}