using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IControl_v2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);
        public int user_id { get; set; }
        public int permission { get; set; }
        public string password { get; set; }        
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtbox_userid.Text == "MODE" && txtbox_password.Text == "configuration")
            {
                var config = new Configuration();
                config.ShowDialog();
            }
            else
            {

            if (string.IsNullOrEmpty(txtbox_userid.Text))
            {                
                toolTip1.Show("Please enter UserID", txtbox_userid, 1000);                
                txtbox_userid.Focus();
                return;
            }
            else
            {
                user_id = Convert.ToInt32(txtbox_userid.Text);
            }
            if (string.IsNullOrEmpty(txtbox_password.Text))
            {
                toolTip1.Show("Please enter Password", txtbox_password, 1000);
                txtbox_password.Focus();
                return;
            }
            else
            {
                password = txtbox_password.Text;
            }            
            string sql_login = "Select id_permission FROM users WHERE id_user = '" + user_id + "' AND password = '" + password + "' ";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(sql_login, con);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    permission = reader.GetInt32(0);
                }
                con.Close();
                var menu = new MainMenu(user_id, permission);                
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserID or Password is not correct.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            }
        }  //Login button get userid and password        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();                     
        }  //Close application
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }  //when closing, close all forms        
        private void txtbox_password_Enter(object sender, EventArgs e)
        {
            if (chkbox_password.Checked == true)
            {
                txtbox_password.isPassword = false;
            }
            else
            {
                txtbox_password.isPassword = true;
            }
        }  //Check checkbox
        private void chkbox_password_OnChange(object sender, EventArgs e)
        {
            if (chkbox_password.Checked == true)
            {
                txtbox_password.isPassword = false;
            }
            else
            {
                txtbox_password.isPassword = true;
            }
        } //SHOW PASSWORD
        private void txtbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 13)
            {
                this.btn_login_Click(null, null);
            }
        }// PRESS LOGIN BUTTON
        private void txtbox_userid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtbox_password.Focus();
            }
        } 
        private void link_recovery_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recovery = new Recovery();
            recovery.ShowDialog();
        } //OPEN RECOVERY ACCOUNT
    }
}
