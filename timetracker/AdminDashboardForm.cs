using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
	public partial class AdminDashboardForm : Form
	{
		public AdminDashboardForm()
		{
			InitializeComponent();
			tbFreq.Text = Configuration.ScreenshottingFrequency.ToString();
			tbKBInterval.Text = Configuration.MaxKeyboardIdleInterval.ToString();
			tbMouseInterval.Text = Configuration.MaxMouseIdleInterval.ToString();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			Configuration.ScreenshottingFrequency = Int32.Parse(tbFreq.Text);
			Configuration.MaxKeyboardIdleInterval = Int32.Parse(tbKBInterval.Text);
			Configuration.MaxMouseIdleInterval = Int32.Parse(tbMouseInterval.Text);
		}

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            gbUser.Enabled = false;
            
            UpdateLists();
        }

        private void UpdateLists()
        {
            listboxProjects.DataSource = ProjectModel.List();
            listboxUsers.DataSource = UserModel.List();
            listboxWorktypes.DataSource = WorkTypeModel.List();
        }

        private void tsbAddUser_Click(object sender, EventArgs e)
        {
            new User().Save();
            UpdateLists();
        }

        private void tsbAddProject_Click(object sender, EventArgs e)
        {
            new Project().Save();
            UpdateLists();
        }
        
        private void tsbAddWorktype_Click(object sender, EventArgs e)
        {
            new WorkType().Save();
            UpdateLists();
        }

        User editedUser = null;
        private void listboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbUser.Enabled = false;
            tsbRemoveUser.Enabled = false;
            editedUser = null;
            btOpenDir.Enabled = false;
            btOpenStats.Enabled = false;
            if (listboxUsers.SelectedItem != null)
            {
                try
                {
                    editedUser = (User)listboxUsers.SelectedItem;
                    gbUser.Enabled = true;
                    if(editedUser.Id!= Auth.CurrentUser.Id)
                        tsbRemoveUser.Enabled = true;
                    showEditedUserData();
                } catch(Exception ex)
                {

                }  
            }
        }

        private void showEditedUserData()
        {
            if (editedUser == null) return;
            tbUserLogin.Text = editedUser.Login;
            tbUserFullName.Text = editedUser.FullName;
            tbUserAddress.Text = editedUser.Address;
            tbUserGSTNumber.Text = editedUser.GSTNumber;
            tbUserIRDNumber.Text = editedUser.IRDNumber;
            cbUserEnabled.Checked = editedUser.Enabled;
            cbUserIsAdmin.Checked = editedUser.IsAdmin;
            if (!editedUser.IsAdmin)
            {
                btOpenDir.Enabled = true;
                btOpenStats.Enabled = true;
            }
        }
        private void btUserSave_Click(object sender, EventArgs e)
        {
            editedUser.Login        = tbUserLogin.Text;
            editedUser.FullName     = tbUserFullName.Text;
            editedUser.Address      = tbUserAddress.Text;
            editedUser.GSTNumber    = tbUserGSTNumber.Text;
            editedUser.IRDNumber    = tbUserIRDNumber.Text;
            if(tbUserPassword.Text != "")
            {
                editedUser.SetPassword(tbUserPassword.Text);
            }

            editedUser.Enabled      = cbUserEnabled.Checked;
            editedUser.IsAdmin      = cbUserIsAdmin.Checked;

            editedUser.Save();
            UpdateLists();
            MessageBox.Show("User saved");
        }

        private void btUserCancel_Click(object sender, EventArgs e)
        {
            showEditedUserData(); //reset
        }

        private void tsbRemoveUser_Click(object sender, EventArgs e)
        {
            if(editedUser!= null)
            {
                editedUser.Delete();
                editedUser = null;
                tsbRemoveUser.Enabled = false;
                UpdateLists();
            }
        }

        private void btOpenDir_Click(object sender, EventArgs e)
        {
            string userDir = Screenshots.GetDirectoryName(editedUser);
            Process.Start("explorer.exe",userDir);
        }

        private void btOpenStats_Click(object sender, EventArgs e)
        {
            MyStatsForm statsForm = new MyStatsForm();
            statsForm.SetExaminedUser(editedUser);
            statsForm.ShowDialog();
        }
    }
}
