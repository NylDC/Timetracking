namespace timetracker
{
    partial class SplashForm
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
            this.lbQuote = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.hideSplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbQuote
            // 
            this.lbQuote.BackColor = System.Drawing.Color.Transparent;
            this.lbQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuote.ForeColor = System.Drawing.Color.White;
            this.lbQuote.Location = new System.Drawing.Point(26, 39);
            this.lbQuote.Name = "lbQuote";
            this.lbQuote.Size = new System.Drawing.Size(484, 175);
            this.lbQuote.TabIndex = 0;
            this.lbQuote.Text = "Robots will harvest, cook, and serve our food. They will work in our factories, d" +
    "rive our cars, and walk our dogs. Like it or not, the age of work is coming to a" +
    "n end.";
            this.lbQuote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(29, 227);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(481, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Leo Tolstoy";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hideSplashTimer
            // 
            this.hideSplashTimer.Enabled = true;
            this.hideSplashTimer.Interval = 5000;
            this.hideSplashTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetracker.Properties.Resources.abstract_abstract_expressionism_abstract_painting_1143770;
            this.ClientSize = new System.Drawing.Size(541, 346);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SplashForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.Shown += new System.EventHandler(this.SplashForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuote;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Timer hideSplashTimer;
    }
}