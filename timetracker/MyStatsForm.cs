using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timetracker.Models;
using timetracker.Services;
using timetracker.Structs;

namespace timetracker
{
    /// <summary>
    /// Form displays work performed for ExaminedUser (default = Auth.CurrentUser)
    /// </summary>
    public partial class MyStatsForm : Form
    {
        private User ExaminedUser;
        public MyStatsForm()
        {
            SetExaminedUser(Auth.CurrentUser);
            InitializeComponent();
        }

        internal void SetExaminedUser(User user)
        {
            ExaminedUser = user;
        }

        private void MyStatsForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ReloadData()
        {
            Text = "Statistics for " + ExaminedUser.FullName;
            lvStats.Items.Clear();
            Dictionary<int, ListViewGroup> listGroups = new Dictionary<int, ListViewGroup>();
            foreach (var work in WorkModel.List(ExaminedUser))
            {
                if (!listGroups.Keys.Contains(work.ProjectId))
                {
                    listGroups[work.ProjectId] = new ListViewGroup()
                    {
                        Header = work.Project.Name
                    };
                }
                var newitem = new ListViewItem();
                newitem.Text = work.Comment;
                newitem.SubItems.Add(work.WorkType.Name);
                newitem.SubItems.Add(work.TimeFormatted);

                listGroups[work.ProjectId].Items.Add(newitem);
            }
            foreach (ListViewGroup lg in listGroups.Values)
            {
                lvStats.Groups.Add(lg);
                foreach (ListViewItem lvm in lg.Items)
                {
                    lvStats.Items.Add(lvm);
                }
            }
        }
    }
}
