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
		/// <summary>
		/// This gives ability to the user to register themselves and it will be recorded 
		/// to the admin dashboard form.
		/// </summary>
		private void btRegSubmit_Click(object sender, EventArgs e)
		{
			//TO DO: USERS MUST HAVE THE ABILITY TO REGISTER THEMSELVES AND THE SYSTEM MUST BE ABLE TO RECOGNISE
			//TO DO: SYSTEM MUST RECOGNISE IF USER IS DUPLICATED
			
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

			AddUser.Save();

			MessageBox.Show("You have successfuly registered");
		}

		/// <summary>
		/// Recognise if the user entered a duplicate username and return the value
		/// </summary>
		/// <returns></returns>
		private bool CheckIsUserExist()
		{
			try
			{
				User tmpUser = UserModel.FindOne(new WhereGroup { new WhereCondition("Login", (tbLogin.Text)) });

				MessageBox.Show("User exist, please use a different user!!!!");
				btRegSubmit.Enabled = false;
				return false;
			}
			catch (Exception){ return true; }	
		}
		private void btRegExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void Registration_Load(object sender, EventArgs e)
		{
			btRegSubmit.Enabled = false;
		}
		private void tbLogin_TextChanged(object sender, EventArgs e)
		{
			btRegSubmit.Enabled = CheckIsUserExist();
		}
	}
}
