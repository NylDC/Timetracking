using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using timetracker.Services;
using timetracker.Models;
using timetracker.Structs;

namespace timetracker
{
	public partial class Registration : Form
	{
		public Registration()
		{
			InitializeComponent();
		}

		User AddUser=null;
		private void btRegSubmit_Click(object sender, EventArgs e)
		{
			//TO DO: USERS MUST HAVE THE ABILITY TO REGISTER THEMSELVES AND THE SYSTEM MUST BE ABLE TO RECOGNISE

			User AddUser = new User();
			AddUser.Login = tbLogin.Text;
			AddUser.FullName = tbFullname.Text;
			AddUser.Address = tbAddress.Text;
			AddUser.GSTNumber = tbGstNum.Text;
			AddUser.IRDNumber = tbIRDNumber.Text;
			if (tbPassword.Text != "")
			{
				AddUser.SetPassword(tbPassword.Text);
			}

			//AddUser.Enabled = cbUserEnabled.Checked;
			//AddUser.IsAdmin = cbUserIsAdmin.Checked;

			AddUser.Save();
			//UpdateLists();
			MessageBox.Show("You have successfuly registered");


		} 

		private void btRegExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Registration_Load(object sender, EventArgs e)
		{
	
		}
	}
}
