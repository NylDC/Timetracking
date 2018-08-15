namespace timetracker
{
    partial class MyStatsForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("2018/01/01", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("2018/01/04", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "123",
            "sub1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("234");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3434343");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("343434");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("343434");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("34343");
            this.lvStats = new System.Windows.Forms.ListView();
            this.chWorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorkedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvStats
            // 
            this.lvStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWorkName,
            this.chWorkType,
            this.chWorkedTime});
            listViewGroup1.Header = "2018/01/01";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "";
            listViewGroup2.Header = "2018/01/04";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup2.Tag = "jhjhj";
            this.lvStats.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup2;
            this.lvStats.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvStats.Location = new System.Drawing.Point(12, 12);
            this.lvStats.Name = "lvStats";
            this.lvStats.Size = new System.Drawing.Size(573, 286);
            this.lvStats.TabIndex = 1;
            this.lvStats.UseCompatibleStateImageBehavior = false;
            this.lvStats.View = System.Windows.Forms.View.Details;
            this.lvStats.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chWorkType
            // 
            this.chWorkType.Text = "Work Type";
            this.chWorkType.Width = 147;
            // 
            // chWorkedTime
            // 
            this.chWorkedTime.Text = "Time Worked";
            this.chWorkedTime.Width = 80;
            // 
            // chWorkName
            // 
            this.chWorkName.Text = "Work done";
            this.chWorkName.Width = 335;
            // 
            // MyStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.lvStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MyStatsForm";
            this.Text = "MyStatsForm";
            this.Load += new System.EventHandler(this.MyStatsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvStats;
        private System.Windows.Forms.ColumnHeader chWorkType;
        private System.Windows.Forms.ColumnHeader chWorkedTime;
        private System.Windows.Forms.ColumnHeader chWorkName;
    }
}