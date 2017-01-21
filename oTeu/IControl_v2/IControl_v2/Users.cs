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
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }
        public int id_user { get; set; }
        public int id_permission { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string cellphone { get; set; }
        public string email { get; set; }
        public int id_address { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public int userid_temp { get; set; }
        public int addressid_temp { get; set; }
        public string permission_name_temp { get; set; }
        public int new_address { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);
        void LoadUsers()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From users ", con);
            DataTable dt = new DataTable();
            DataColumn dataColumn = new DataColumn("id_permission");
            dataColumn.DataType = typeof(String);
            dt.Columns.Add(dataColumn);
            sda.Fill(dt);
            dt.Columns["id_permission"].SetOrdinal(2);
            dgv_users_list.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string permission = dt.Rows[i]["id_permission"].ToString();
                string permission_name = "";
                string sql = "SELECT permission_name FROM users_permissions WHERE id_permission = '" + permission + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    permission_name = reader.GetString(0);
                }
                dt.Rows[i]["id_permission"] = permission_name;
            }
            dgv_users_list.DataSource = dt;
            con.Close();
            dgv_users_list.Columns["id_user"].HeaderText = "UserID";
            dgv_users_list.Columns["id_permission"].HeaderText = "Permission";
            dgv_users_list.Columns["password"].HeaderText = "Password";
            dgv_users_list.Columns["first_name"].HeaderText = "First Name";
            dgv_users_list.Columns["last_name"].HeaderText = "Last Name";
            dgv_users_list.Columns["gender"].HeaderText = "Gender";
            dgv_users_list.Columns["cellphone"].HeaderText = "Cellphone Number";
            dgv_users_list.Columns["email"].HeaderText = "Email";
        } //LOAD ALL USERS FROM DATABASE
        void LoadPermissions()
        {
            var list = new List<string>();
            string sql = "SELECT permission_name FROM users_permissions";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["permission_name"]));
            }
            cbbox_permission.DataSource = new BindingSource(list, null);
            con.Close();
            cbbox_permission.Text = ("");
        } //LOAD PERMISSIONS
        void LoadUserAddress()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id_address,address,city,country,zip FROM address WHERE id_user = '" + userid_temp + "' ", con);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_address.DataSource = dt;
            con.Close();
            dgv_address.Columns["id_address"].HeaderText = "AddressID";
            dgv_address.Columns["address"].HeaderText = "Address";
            dgv_address.Columns["country"].HeaderText = "Country";
            dgv_address.Columns["city"].HeaderText = "City";
            dgv_address.Columns["zip"].HeaderText = "Zip-Code";
        } //LOAD USERS ADDRESS FROM DATABASE
        void LoadUserPermission()
        {
            string sql_get = "Select permission_name FROM users_permissions WHERE id_permission = '" + id_permission + "' ";
            SqlCommand cmd = new SqlCommand(sql_get, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                permission_name_temp = reader.GetString(0);
            }
            cbbox_permission.Text = permission_name_temp;
        } //LOAD PERMISSION FROM THE USER
        void ClearTextBox()
        {
            txtbox_userid.Clear();
            txtbox_password.Clear();
            txtbox_firstname.Clear();
            txtbox_lastname.Clear();
            cbbox_gender.Text = "";
            txtbox_cellphone.Clear();
            txtbox_email.Clear();
            txtbox_addressid.Clear();
            txtbox_address.Clear();
            txtbox_country.Clear();
            txtbox_city.Clear();
            txtbox_zip_code.Clear();
            cbbox_permission.Text = ("");
        } //CLEAR ALL TEXTBOXS
        public void GetUsersInfo()
        {
            if (string.IsNullOrEmpty(txtbox_password.Text))
            {
                password = "1234";
            }
            else
            {
                password = txtbox_password.Text;
            }
            first_name = txtbox_firstname.Text;
            last_name = txtbox_lastname.Text;
            gender = cbbox_gender.Text;
            cellphone = txtbox_cellphone.Text;
            email = txtbox_email.Text;
            permission_name_temp = cbbox_permission.Text;
            con.Open();
            string sql_get = "Select id_permission FROM users_permissions WHERE permission_name = '" + permission_name_temp + "' ";
            SqlCommand cmd = new SqlCommand(sql_get, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_permission = reader.GetInt32(0);
            }
            con.Close();
        } //SAVE USERS INFORMATION IN TEXTBOX TO STRINGS AND INTS
        void GetUsersAddressInfo()
        {
            address = txtbox_address.Text;
            country = txtbox_country.Text;
            city = txtbox_city.Text;
            zip = txtbox_zip_code.Text;
        } //SAVE ADDRESS INFORMATION IN TEXTBOX TO STRINGS AND INTS
        void AutoComplete()
        {
            txtbox_country.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbox_country.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            txtbox_city.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbox_city.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cool = new AutoCompleteStringCollection();
            string sql = "Select country, city From address";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd;
            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string fcountry = rd.GetString(rd.GetOrdinal("country"));
                    coll.Add(fcountry);
                    string fcity = rd.GetString(rd.GetOrdinal("city"));
                    cool.Add(fcity);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtbox_country.AutoCompleteCustomSource = coll;
            txtbox_city.AutoCompleteCustomSource = cool;
        } //LOAD SAVED CITY AND COUTRIES FROM DATA BASE

        private void btn_save_Click(object sender, EventArgs e)
        {
            GetUsersInfo();
            GetUsersAddressInfo();
            con.Open();
            if (txtbox_userid.Text == "")
            {
                string sql_new = "INSERT INTO users (id_permission,password,first_name,last_name,gender,cellphone,email) VALUES ( '" + id_permission + "', '" + password + "' , '" + first_name + "' ,'" + last_name + "' ,'" + gender + "','" + cellphone + "', '" + email + "')";
                SqlCommand cmd = new SqlCommand(sql_new, con);
                cmd.ExecuteNonQuery();
                if (new_address == 1)
                {
                    string sql_id = "Select * from users where id_user = (Select MAX(id_user) From users)";
                    SqlCommand cmd1 = new SqlCommand(sql_id, con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        id_user = reader.GetInt32(0);
                    }
                    userid_temp = id_user;
                    string sql_new_address = "INSERT INTO address (id_user,address,country,city,zip) VALUES ( '" + userid_temp + "','" + address + "' ,'" + country + "', '" + city + "','" + zip + "') ";
                    SqlCommand cmd2 = new SqlCommand(sql_new_address, con);
                    cmd2.ExecuteNonQuery();
                    new_address = 0;
                }
            }
            else
            {
                string sql_edit = "UPDATE users SET id_permission = '" + id_permission + "' ,password = '" + password + "' ,first_name = '" + first_name + "',last_name = '" + last_name + "',gender = '" + gender + "',cellphone = '" + cellphone + "',email = '" + email + "' WHERE id_user = '" + userid_temp + "' ";
                SqlCommand cmd = new SqlCommand(sql_edit, con);
                cmd.ExecuteNonQuery();
                if (gb_address.Enabled == true)
                {
                    if (new_address == 1)
                    {
                        string sql_new_address = "INSERT INTO address (id_user,address,country,city,zip) VALUES ( '" + userid_temp + "','" + address + "' ,'" + country + "', '" + city + "','" + zip + "') ";
                        SqlCommand cmd2 = new SqlCommand(sql_new_address, con);
                        cmd2.ExecuteNonQuery();
                        new_address = 0;
                    }
                    else if (txtbox_addressid.Text != "")
                    {
                        string sql_edit_address = "UPDATE address SET address = '" + address + "' ,country = '" + country + "',city = '" + city + "',zip = '" + zip + "' WHERE id_address =  '" + addressid_temp + "' ";
                        SqlCommand cmd2 = new SqlCommand(sql_edit_address, con);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving existe user address");
                    }
                }
            }
            gb_address.Enabled = false;
            btn_newaddress.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            btn_new.Enabled = true;
            con.Close();
            MessageBox.Show("User was be Saved succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUserAddress();
            LoadUsers();
            ClearTextBox();
            AutoComplete();
            tabControl1.SelectTab(users_list);
        } //SAVE User AND ADDRESS INFORMATION

        private void btn_deleteaddress_Click(object sender, EventArgs e)
        {
            if (addressid_temp == 0)
            {
                MessageBox.Show("Select a Address to Delete");
            }
            else
            {
                if ((MessageBox.Show("Are you sure you want to delete this Address?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    string delete_user_address = "DELETE FROM address where id_address = '" + addressid_temp + "'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(delete_user_address, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Address was be deleted succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
            LoadUserAddress();
        } //DELETE ONLY ADDRESS
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (userid_temp == 0)
            {
                MessageBox.Show("Select a user to Delete");
            }
            else
            {
                if ((MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    string delete_user = "DELETE FROM users where id_user = '" + userid_temp + "'";
                    string delete_user_address = "DELETE FROM address where id_user = '" + userid_temp + "'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(delete_user_address, con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(delete_user, con);
                    cmd.ExecuteNonQuery();
                    userid_temp = 0;
                    con.Close();
                    MessageBox.Show("User was be deleted succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadUsers();
            LoadUserAddress();
        } //DELETE user AND ADDRESS
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            userid_temp = 0;
            addressid_temp = 0;
            new_address = 0;
            ClearTextBox();
            gb_address.Enabled = false;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            btn_new.Enabled = true;
            con.Close();
            tabControl1.SelectTab(users_list);
        } //CANCEL BUTTON
        private void dgv_address_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv_address.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_address.Rows[selectedrowindex];
            addressid_temp = Convert.ToInt32(selectedRow.Cells["id_address"].Value);
            gb_address.Enabled = true;
            string sql_edit_address = "Select id_address,address,country,city,zip FROM address WHERE id_address = '" + addressid_temp + "'";
            SqlCommand cmd = new SqlCommand(sql_edit_address, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_address = reader.GetInt32(0);
                address = reader.GetString(1);
                country = reader.GetString(2);
                city = reader.GetString(3);
                zip = reader.GetString(4);
            }
            txtbox_addressid.Text = Convert.ToString(id_address);
            txtbox_address.Text = address;
            txtbox_country.Text = country;
            txtbox_city.Text = city;
            txtbox_zip_code.Text = zip;
            con.Close();
        } //LOAD ADDRESS INFORMATION
        private void btn_newaddress_Click(object sender, EventArgs e)
        {
            txtbox_addressid.Clear();
            txtbox_address.Clear();
            txtbox_country.Clear();
            txtbox_city.Clear();
            txtbox_zip_code.Clear();
            gb_address.Enabled = true;
            btn_newaddress.Enabled = false;
            new_address = 1;
        }//ADD NEW ADDRESS
        private void dgv_users_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedrowindex = dgv_users_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_users_list.Rows[selectedrowindex];
            userid_temp = Convert.ToInt32(selectedRow.Cells["id_user"].Value);
            LoadUserAddress();
        } //LOAD userS INFORMATION
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (userid_temp == 0)
            {
                MessageBox.Show("Select a user to Edit");
            }
            else
            {
                btn_newaddress.Enabled = true;
                gb_address.Enabled = false;
                string sql_edit = "Select * FROM users WHERE id_user = '" + userid_temp + "'";
                SqlCommand cmd = new SqlCommand(sql_edit, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_user = reader.GetInt32(0);
                    id_permission = reader.GetInt32(1);
                    password = reader.GetString(2);
                    first_name = reader.GetString(3);
                    last_name = reader.GetString(4);
                    gender = reader.GetString(5);
                    cellphone = reader.GetString(6);
                    email = reader.GetString(7);
                }
                LoadUserPermission();
                txtbox_userid.Text = Convert.ToString(id_user);
                txtbox_password.Text = password;
                txtbox_firstname.Text = first_name;
                txtbox_lastname.Text = last_name;
                cbbox_gender.Text = gender;
                txtbox_cellphone.Text = cellphone;
                txtbox_email.Text = email;
                tabControl1.SelectTab(new_edit_user);
                con.Close();
            }
        } //EDIT CLIENT AND LOAD INFORMATION
        private void Users_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            LoadUsers();
            AutoComplete();
            LoadPermissions();
            userid_temp = 0;
            addressid_temp = 0;
            new_address = 0;
        }
        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_search.Text == "")
            {
                LoadUsers();
            }
            else
            {
                string search = txtbox_search.Text;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * From users WHERE first_name LIKE '" + search + "%' OR last_name LIKE '" + search + "%' ", con);
                DataTable dt = new DataTable();
                DataColumn dataColumn = new DataColumn("id_permission");
                dataColumn.DataType = typeof(String);
                dt.Columns.Add(dataColumn);
                sda.Fill(dt);
                dt.Columns["id_permission"].SetOrdinal(2);
                dgv_users_list.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    string permission = dt.Rows[i]["id_permission"].ToString();
                    string permission_name = "";
                    string sql = "SELECT permission_name FROM users_permissions WHERE id_permission = '" + permission + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        permission_name = reader.GetString(0);
                    }
                    dt.Rows[i]["id_permission"] = permission_name;
                }
                dgv_users_list.DataSource = dt;
                con.Close();
                dgv_users_list.Columns["id_user"].HeaderText = "UserID";
                dgv_users_list.Columns["id_permission"].HeaderText = "Permission";
                dgv_users_list.Columns["password"].HeaderText = "Password";
                dgv_users_list.Columns["first_name"].HeaderText = "First Name";
                dgv_users_list.Columns["last_name"].HeaderText = "Last Name";
                dgv_users_list.Columns["gender"].HeaderText = "Gender";
                dgv_users_list.Columns["cellphone"].HeaderText = "Cellphone Number";
                dgv_users_list.Columns["email"].HeaderText = "Email";
            }
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(new_edit_user);
            ClearTextBox();
        }
    }
}
