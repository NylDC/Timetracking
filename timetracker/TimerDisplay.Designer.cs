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
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(24, 17);
            this.lbTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(409, 107);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(20, 127);
            this.btStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(120, 52);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btResume
            // 
            this.btResume.Enabled = false;
            this.btResume.Location = new System.Drawing.Point(152, 127);
            this.btResume.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(150, 52);
            this.btResume.TabIndex = 3;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(314, 127);
            this.btStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(120, 52);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // TimerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTime);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimerDisplay";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btStop;
    }
}