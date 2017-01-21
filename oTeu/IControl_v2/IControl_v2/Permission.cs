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
    public partial class Permission : UserControl
    {
        public Permission()
        {
            InitializeComponent();
        }

        private void Permission_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            LoadPermissions();
        }
        
        public int id_permission { get; set; }
        public string permission_name { get; set; }
        public string permission_description { get; set; }
        public int menu_clients { get; set; }
        public int menu_client_password { get; set; }
        public int menu_orders { get; set; }
        public int menu_products { get; set; }
        public int menu_suppliers { get; set; }
        public int menu_users { get; set; }
        public int menu_permissions { get; set; }
        public int menu_admin_settings { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        void LoadPermissions()
        {
            var list = new List<string>();
            string sql = "SELECT permission_name FROM users_permissions";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            list.Add("");
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["permission_name"]));
            }
            con.Close();
            cbbox_permission_name.DataSource = new BindingSource(list, null);
        } //LOAD PERMISSIONS NAME FROM DATABASE

        private void cbbox_permission_name_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            txtbox_description.Clear();
            chk_clients_menu.Checked = false;
            chk_clients_password.Checked = false;
            chk_orders_menu.Checked = false;
            chk_products_menu.Checked = false;
            chk_suppliers_menu.Checked = false;
            chk_users_menu.Checked = false;
            chk_permissions_menu.Checked = false;
            chk_admin_settings.Checked = false;
            permission_name = cbbox_permission_name.Text;
            string sql = "Select * FROM users_permissions WHERE permission_name = '" + permission_name + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_permission = reader.GetInt32(0);
                    permission_name = reader.GetString(1);
                    permission_description = reader.GetString(2);
                    menu_clients = reader.GetInt32(3);
                    menu_client_password = reader.GetInt32(4);
                    menu_orders = reader.GetInt32(5);
                    menu_products = reader.GetInt32(6);
                    menu_suppliers = reader.GetInt32(7);
                    menu_users = reader.GetInt32(8);
                    menu_permissions = reader.GetInt32(9);
                    menu_admin_settings = reader.GetInt32(10);
                }
                con.Close();
                txtbox_description.Text = permission_description;
                if (menu_clients == 1)
                {
                    chk_clients_menu.Checked = true;
                }
                if (menu_client_password == 1)
                {
                    chk_clients_password.Checked = true;
                }
                if (menu_orders == 1)
                {
                    chk_orders_menu.Checked = true;
                }
                if (menu_products == 1)
                {
                    chk_products_menu.Checked = true;
                }
                if (menu_suppliers == 1)
                {
                    chk_suppliers_menu.Checked = true;
                }
                if (menu_users == 1)
                {
                    chk_users_menu.Checked = true;
                }
                if (menu_permissions == 1)
                {
                    chk_permissions_menu.Checked = true;
                }
                if(menu_admin_settings == 1)
                {
                    chk_admin_settings.Checked = true;
                }
            }
        } //AUTO FILL DATA WHEN TEXT CHANGE
        private void chk_clients_menu_OnChange(object sender, EventArgs e)
        {

            if (chk_clients_menu.Checked == true)
            {
                chk_clients_password.Enabled = true;
            }
            else
            {
                chk_clients_password.Enabled = false;
                chk_clients_password.Checked = false;
            }
        }//VERIFICAR CLIENTS CHECK BUTTON
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_permission_name.Text))
            {
                toolTip_text.Show("Please enter Permission Name.", cbbox_permission_name, 1000);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                permission_name = cbbox_permission_name.Text;
                permission_description = txtbox_description.Text;
                menu_clients = 0;
                menu_client_password = 0;
                menu_orders = 0;
                menu_products = 0;
                menu_suppliers = 0;
                menu_users = 0;
                menu_permissions = 0;
                menu_admin_settings = 0;
                if (chk_clients_menu.Checked == true)
                {
                    menu_clients = 1;
                }
                if (chk_clients_password.Checked == true)
                {
                    menu_client_password = 1;
                }
                if (chk_orders_menu.Checked == true)
                {
                    menu_orders = 1;
                }
                if (chk_products_menu.Checked == true)
                {
                    menu_products = 1;
                }
                if (chk_suppliers_menu.Checked == true)
                {
                    menu_suppliers = 1;
                }
                if (chk_users_menu.Checked == true)
                {
                    menu_users = 1;
                }
                if (chk_permissions_menu.Checked == true)
                {
                    menu_permissions = 1;
                }
                if(chk_admin_settings.Checked == true)
                {
                    menu_admin_settings = 1;
                }
                string sql = "Select * FROM users_permissions WHERE permission_name = '" + permission_name + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string sql_update = "UPDATE users_permissions SET permission_description = '" + permission_description + "', menu_clients = '" + menu_clients + "', menu_clients_password = '" + menu_client_password + "', menu_orders = '" + menu_orders + "' ,menu_products = '" + menu_products + "', menu_suppliers = '" + menu_suppliers + "' , menu_users = '" + menu_users + "', menu_permission = '" + menu_permissions + "', menu_admin_settings = '" + menu_admin_settings + "'  WHERE permission_name = '" + permission_name + "' ";
                    SqlCommand cmd2 = new SqlCommand(sql_update, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Permission '" + permission_name + "' updated succesfull! ");
                }
                else
                {
                    string sql_insert = "INSERT INTO users_permissions (permission_name, permission_description, menu_clients, menu_clients_password, menu_orders, menu_products, menu_suppliers, menu_users, menu_permission, menu_admin_settings) VALUES ( '" + permission_name + "','" + permission_description + "','" + menu_clients + "','" + menu_client_password + "','" + menu_orders + "' ,'" + menu_products + "','" + menu_suppliers + "' ,'" + menu_users + "','" + menu_permissions + "','" + menu_admin_settings + "')";
                    SqlCommand cmd3 = new SqlCommand(sql_insert, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Permissions '" + permission_name + "' was been created");
                }
                con.Close();
                LoadPermissions();
            }
        }  //SAVE BUTTON
        private void chk_clients_password_OnChange(object sender, EventArgs e)
        {

        }        
        private void btn_delete_cLICK(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_permission_name.Text))
            {
                return;
            }
            else
            {
                permission_name = cbbox_permission_name.Text;
                if (MessageBox.Show("Are you sure you want to Delete '" + permission_name + "' ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql_delete = "DELETE FROM users_permissions WHERE permission_name = '" + permission_name + "'";
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand(sql_delete, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this permission while it is in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Abort", "Abort");

                }
                LoadPermissions();
            }
        }  //DELETE BUTTON
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void chk_clients_password_Click(object sender, EventArgs e)
        {
            if(chk_clients_menu.Checked == false)
            {
                toolTip_text.Show("Please enable clients menu first", chk_clients_password, 1000);
            }
        }
    }
}
