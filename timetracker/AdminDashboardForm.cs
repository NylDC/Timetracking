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
            tbVideoFrequency.Text = Configuration.VideoFPS.ToString();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			Configuration.ScreenshottingFrequency = Int32.Parse(tbFreq.Text);
			Configuration.MaxKeyboardIdleInterval = Int32.Parse(tbKBInterval.Text);
			Configuration.MaxMouseIdleInterval = Int32.Parse(tbMouseInterval.Text);
            Configuration.VideoFPS = Int32.Parse(tbVideoFrequency.Text);
		}

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            gbUser.Enabled = false;
            
            UpdateLists();
        }

        bool isInternalUpdate = true;
        User editedUser = null;
        Project editedProject = null;
        WorkType editedWorkType = null;

        private void UpdateLists()
        {
            isInternalUpdate = true;

            listboxProjects.DataSource = ProjectModel.List();
            listboxUsers.DataSource = UserModel.List();
            listboxWorktypes.DataSource = WorkTypeModel.List();

            
            /* Checked Boxes Lists of Processes and Urls  START*/
            ChkLBoxProcesses.DataSource = ProcessesAndUrlsModel.List(false);
            ChkLBoxUrls.DataSource = ProcessesAndUrlsModel.List(true);

            for (int i = 0; i < ChkLBoxProcesses.Items.Count; i++)
            {
                ProcessesAndUrls a = (ProcessesAndUrls)ChkLBoxProcesses.Items[i];
                ChkLBoxProcesses.SetItemChecked(i, a.IsAllowed);
            }

           
            for (int i = 0; i<  ChkLBoxUrls.Items.Count; i++)
            {
                ProcessesAndUrls a = (ProcessesAndUrls)ChkLBoxUrls.Items[i];
                ChkLBoxUrls.SetItemChecked(i, a.IsAllowed);
            }
            /* Checked Boxes Lists of Processes and Urls  END*/
            isInternalUpdate = false;
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
            showEditedUserData();
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


        private void listboxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxProjects.SelectedItem != null)
            {
                try
                {
                    editedProject = (Project)listboxProjects.SelectedItem;
                    
                    showEditedProjectData();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void showEditedProjectData()
        {
            if (editedProject == null) return;
            tbProjectName.Text = editedProject.Name;
            cbMakeScreenshots.Checked = editedProject.MakeScreenshots;
            cbCheckApplications.Checked = editedProject.CheckApps;
            cbCheckKeyboard.Checked = editedProject.CheckKeyboard;
            cbCheckMouse.Checked = editedProject.CheckMouse;
            cbIsActive.Checked = editedProject.Active;
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            List<string>  comment = PromptDouble.ShowDialog("process", "Add new ");
            if (comment == null) return;

            ProcessesAndUrls proc = new ProcessesAndUrls();
            proc.Alias = comment[0];
            proc.Address = comment[1];
            proc.IsUrl = false;

            proc.Save();
            UpdateLists();
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            List<string> comment = PromptDouble.ShowDialog("URL", "Add new ");
            if (comment == null) return;

            ProcessesAndUrls urls = new ProcessesAndUrls();
            urls.Alias = comment[0];
            urls.Address = comment[1];
            urls.IsUrl = true;

            urls.Save();
            UpdateLists();
        }

        private void ChkLBoxProcesses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if (isInternalUpdate) return;
            else
            {
                ProcessesAndUrls itemProc = (ProcessesAndUrls)ChkLBoxProcesses.Items[e.Index];
                itemProc.IsAllowed = e.NewValue == CheckState.Checked;
                itemProc.Save();
            }

           
        }

        private void ChkLBoxUrls_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if (isInternalUpdate) return;
            else
            {
                ProcessesAndUrls itemUrl = (ProcessesAndUrls)ChkLBoxUrls.Items[e.Index];
                itemUrl.IsAllowed = e.NewValue == CheckState.Checked;
                itemUrl.Save();
            }


        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            ProcessesAndUrls itemProc =  (ProcessesAndUrls)ChkLBoxProcesses.SelectedItem;
            itemProc.Delete();
            UpdateLists();
        }

        private void btnRemoveUrl_Click(object sender, EventArgs e)
        {
            ProcessesAndUrls itemProc = (ProcessesAndUrls)ChkLBoxUrls.SelectedItem;
            itemProc.Delete();
            UpdateLists();
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

        private void ChkLBoxUrls_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveUrl.Enabled = ChkLBoxUrls.SelectedIndex > -1;
        }

        private void ChkLBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveProcess.Enabled = ChkLBoxProcesses.SelectedIndex > -1;
        }

        public void btnEditUrl_Click(object sender, EventArgs e)
        {
            ProcessesAndUrls itemProc = (ProcessesAndUrls)ChkLBoxUrls.SelectedItem;
            List<string> lst = new List<string>();
            lst.Add(itemProc.Alias);
            lst.Add(itemProc.Address);



            List<string> comment = PromptDouble.ShowEditDialog("URL", "Edit", itemProc);

            if (comment == null) return;
            itemProc.Alias = comment[0];
            itemProc.Address = comment[1];
            itemProc.Save();
            UpdateLists();
        }

        private void btnEditProcess_Click(object sender, EventArgs e)
        {
            ProcessesAndUrls itemProc = (ProcessesAndUrls)ChkLBoxProcesses.SelectedItem;
            List<string> comment = PromptDouble.ShowEditDialog("URL", "Edit", itemProc);

            if (comment == null) return;
            itemProc.Alias = comment[0];
            itemProc.Address = comment[1];
            itemProc.Save();
            UpdateLists();
        }

        private void btnProjectSave_Click(object sender, EventArgs e)
        {
            if(tbProjectName.Text == "" || tbProjectName.Text == null)
            {
                MessageBox.Show("Name of the project can not be empty!");
                return;
            }
            editedProject.Name = tbProjectName.Text;
            editedProject.MakeScreenshots = cbMakeScreenshots.Checked;
            editedProject.CheckApps = cbCheckApplications.Checked;
            editedProject.CheckBrowsers = cbCheckUrls.Checked;
            editedProject.CheckKeyboard = cbCheckKeyboard.Checked;
            editedProject.CheckMouse = cbCheckMouse.Checked;

            editedProject.Save();
            UpdateLists();
            MessageBox.Show("Project saved");
        }

        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            showEditedProjectData();
        }

        private void tsbRemoveProject_Click(object sender, EventArgs e)
        {
            if (editedProject != null)
            {
                editedProject.Delete();
                editedProject = null;
                tsbRemoveProject.Enabled = false;
                UpdateLists();
            }
        }

        private void listboxWorktypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            editedWorkType = (WorkType)listboxWorktypes.SelectedItem;
            tbWorktypesName.Text = editedWorkType.Name;
        }

        private void btnWorkypeSave_Click(object sender, EventArgs e)
        {
            if( tbWorktypesName.Text == "" || tbWorktypesName.Text == null)
            {
                MessageBox.Show("Work type's name couldn't be empty!");
                return;
            }
            editedWorkType.Name = tbWorktypesName.Text;
            editedWorkType.Save();
            UpdateLists();

        }

        private void btnWorkypeCancel_Click(object sender, EventArgs e)
        {
            if (editedWorkType == null) return;
            tbWorktypesName.Text = editedWorkType.Name;

        }

        private void tsbRemoveWorktype_Click(object sender, EventArgs e)
        {
            if (editedWorkType != null)
            {
                editedWorkType.Delete();
                editedWorkType = null;
                tsbRemoveWorktype.Enabled = false;
                UpdateLists();
            }
        }
    }
}
