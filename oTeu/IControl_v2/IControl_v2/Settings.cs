using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IControl_v2
{
    public partial class Settings : UserControl
    {
        public int userid { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);
        public Settings(int _userid)
        {
            InitializeComponent();
            this.userid = _userid;
        }
        void LoadStatus()
        {
            var list = new List<string>();
            string sql = "SELECT order_status_name FROM orders_status ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var reader = cmd.ExecuteReader();
            list.Add("");
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["order_status_name"]));
            }
            cbbox_option1.DataSource = new BindingSource(list, null);
            cbbox_option2.DataSource = new BindingSource(list, null);
            con.Close();
        }  //LOAD ORDER STATUS FROM DATABASE
        void LoadUserInformations()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql_load = "SELECT first_name,last_name,gender,cellphone,email FROM users WHERE id_user ='" + userid + "'";
            SqlCommand cmd = new SqlCommand(sql_load, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtbox_userid.Text = Convert.ToString(userid);
                txtbox_firstname.Text = reader.GetString(0);
                txtbox_lastname.Text = reader.GetString(1);
                cbbox_gender.Text = reader.GetString(2);
                txtbox_cellphone.Text = reader.GetString(3);
                txtbox_email.Text = reader.GetString(4);
            }
            con.Close();
        } //Load User Information

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string old_password = txtbox_old_password.Text;
            string new_password = txtbox_new_password.Text;
            string comfirm_password = txtbox_comfirm_password.Text;
            if (new_password == comfirm_password)
            {
                string sql = "Select password FROM users WHERE id_user = '" + userid + "' AND password = '" + old_password + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Password has been updated.");
                    string sql_UPDATE = "UPDATE users SET password = '" + new_password + "' WHERE id_user = '" + userid + "' ";
                    SqlCommand cmd1 = new SqlCommand(sql_UPDATE, con);
                    cmd1.ExecuteNonQuery();
                    txtbox_comfirm_password.Clear();
                    txtbox_new_password.Clear();
                    txtbox_old_password.Clear();
                    con.Close();
                }
                else
                {
                    toolTip1.Show("Wrong Password.", txtbox_old_password, 1000);
                    txtbox_old_password.Focus();
                    return;
                }                
            }                       
            else
            {
                toolTip1.Show("Password doesn't match.", txtbox_new_password, 1000);
                txtbox_new_password.Focus();
            }
            
        } //SAVE NEW PASSWORD
        private void chk_show_password_OnChange(object sender, EventArgs e)
        {
            if(chk_show_password.Checked == true)
            {
                txtbox_comfirm_password.UseSystemPasswordChar = false;
                txtbox_new_password.UseSystemPasswordChar = false;
                txtbox_old_password.UseSystemPasswordChar = false;
            }
            else
            {
                txtbox_comfirm_password.UseSystemPasswordChar = true;
                txtbox_new_password.UseSystemPasswordChar = true;
                txtbox_old_password.UseSystemPasswordChar = true;
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadUserInformations();
            LoadStatus();
        }
        private void btn_save_profile_Click(object sender, EventArgs e)
        {
            if (groupBox3.Enabled == true)
            {
                string sql_UPDATE = "UPDATE users SET first_name = '" + txtbox_firstname.Text + "', last_name = '" + txtbox_lastname.Text + "', gender = '" + cbbox_gender.Text + "', cellphone = '" + txtbox_cellphone.Text + "', email = '" + txtbox_email.Text + "' WHERE id_user = '" + userid + "' ";
                SqlCommand cmd1 = new SqlCommand(sql_UPDATE, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Your informations was updated successfully");
                LoadUserInformations();
                con.Close();
            }
        }  //Update user information
        private void btn_edit_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }
        private void txtbox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.btn_save_profile_Click(null, null);
            }
        }
        private void txtbox_comfirm_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.btn_save_Click(null, null);
            }
        }
    }
}
