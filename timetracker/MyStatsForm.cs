﻿using System;
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

namespace timetracker
{
    public partial class MyStatsForm : Form
    {
        public MyStatsForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyStatsForm_Load(object sender, EventArgs e)
        {
            lvStats.Items.Clear();
            Dictionary<int, ListViewGroup> listGroups = new Dictionary<int, ListViewGroup>();
            foreach(var work in WorkModel.List(Auth.CurrentUser))
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
                newitem.SubItems.Add(work.Time.ToString());

                listGroups[work.ProjectId].Items.Add(newitem);
            }
            foreach(ListViewGroup lg in listGroups.Values)
            {
                lvStats.Groups.Add(lg);
                foreach(ListViewItem lvm in lg.Items)
                {
                    lvStats.Items.Add(lvm);
                }
            }
        }
    }
}