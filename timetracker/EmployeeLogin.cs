using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using timetracker.Services;

namespace timetracker
{
	public partial class EmployeeLogin : Form
	{
		public EmployeeLogin()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Authenticating the user by entering the username and password
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btLogin_Click(object sender, EventArgs e)
		{

			if (Auth.Authenticate(tbLogin.Text, tbPassword.Text) != null)
			{
				this.Hide();
				btLogin.Show();
				MessageBox.Show("Hi you have successfully login "+ Auth.CurrentUser.FullName, "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Please enter a valid username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btRegister_Click(object sender, EventArgs e)
		{
			Registration RegForm = new Registration();
			RegForm.Show();

		}

		private void EmployeeLogin_Load(object sender, EventArgs e)
		{

		}

		private void tbLogin_Click(object sender, EventArgs e)
		{
			tbLogin.Text = "";		}

		private void tbPassword_Click(object sender, EventArgs e)
		{
			tbPassword.Text = "";
			tbPassword.PasswordChar = '*';
		}

		private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			tbPassword.PasswordChar = '*';
			tbPassword.Text = "";
		}

		private void btRegister_Click_1(object sender, EventArgs e)
		{
			Registration RegForm = new Registration();
			RegForm.Show();
		}

		private void btLogin_Click_1(object sender, EventArgs e)
		{


				if (Auth.Authenticate(tbLogin.Text, tbPassword.Text) != null)
				{
					this.Hide();
					btLogin.Show();
					MessageBox.Show("Hi you have successfully login " + Auth.CurrentUser.FullName, "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Please enter a valid username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}

	
			
		

	

