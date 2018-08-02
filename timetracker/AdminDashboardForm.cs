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
            // TODO: This line of code loads data into the 'dbDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter1.Fill(this.dbDataSet.Projects);
            // TODO: This line of code loads data into the 'dbDataSet.WorkTypes' table. You can move, or remove it, as needed.
            this.workTypesTableAdapter1.Fill(this.dbDataSet.WorkTypes);
            // TODO: This line of code loads data into the 'dbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.dbDataSet.Users);
        }

        private void tsbAddUser_Click(object sender, EventArgs e)
        {
            dbDataSet.Users.AddUsersRow("New User", "123", "New User", 0, 0, "000", "Auckland", "000");
            dbDataSet.AcceptChanges();
        }

        private void tsbAddProject_Click(object sender, EventArgs e)
        {
            dbDataSet.Projects.AddProjectsRow("New Project", 1, 1, 1, 1, 1, 0);
            dbDataSet.AcceptChanges();
        }

        dbDataSet.UsersRow editedUser = null;
        private void listboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            object _id = listboxUsers.SelectedValue;
            if (_id == null)
            {
                gbUser.Enabled = false;
                editedUser = null;
            } else {
                int id = (int)_id;
                try
                {
                    editedUser = dbDataSet.Users.FindById(id);
                    if (editedUser == null) return;
                    gbUser.Enabled = true;
                    tbUserLogin.Text = editedUser.Login;
                    tbUserFullName.Text = editedUser.FullName;
                    cbUserEnabled.Checked = editedUser.Enabled == 1;
                    cbUserIsAdmin.Checked = editedUser.IsAdmin == 1;
                } catch(System.IndexOutOfRangeException ex)
                {

                }  
            }
        }
    }
}
