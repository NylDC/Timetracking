using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetracker
{
	public partial class AdminDashboardForm : Form
	{
		public AdminDashboardForm()
		{
			InitializeComponent();
			tbFreq.Text = Configuration.ScreenshottingFrequency.ToString();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			Configuration.ScreenshottingFrequency = Int32.Parse(tbFreq.Text);
		}

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet1.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet1.WorkTypes' table. You can move, or remove it, as needed.
            this.workTypesTableAdapter.Fill(this.databaseDataSet1.WorkTypes);
            // TODO: This line of code loads data into the 'databaseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);

        }

        private void tsbAddUser_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Insert("New User", "", "", 0, 0);
        }

        private void tsbAddProject_Click(object sender, EventArgs e)
        {
            this.projectsTableAdapter.Insert("New Project", 1, 1, 1, 1, 1, 0);
        }

        private void listboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
