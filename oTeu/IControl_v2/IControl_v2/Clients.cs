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
    public partial class Clients : UserControl
    {
        public Clients(int _menu_clients_password )
        {
            InitializeComponent();
            this.password_permission = _menu_clients_password;
        }

        public int id_client { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public string cellphone { get; set; }
        public string email { get; set; }
        public int id_address { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public int password_permission { get; set; }

        public int clientid_temp { get; set; }
        public int addressid_temp { get; set; }
        public int new_address { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        void LoadClients()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From clients ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (password_permission != 1)
            {
                dt.Columns.Remove("password");
                dgv_clients_list.DataSource = dt;
            }
            else
            {
                dgv_clients_list.DataSource = dt;
                dgv_clients_list.Columns["password"].HeaderText = "Password";
            }            
            con.Close();
            dgv_clients_list.Columns["id_client"].HeaderText = "ClientID";
            dgv_clients_list.Columns["first_name"].HeaderText = "First Name";
            dgv_clients_list.Columns["last_name"].HeaderText = "Last Name";
            dgv_clients_list.Columns["gender"].HeaderText = "Gender";
            dgv_clients_list.Columns["birthday"].HeaderText = "Birthday Date";
            dgv_clients_list.Columns["cellphone"].HeaderText = "Cellphone Number";
            dgv_clients_list.Columns["email"].HeaderText = "Email";
        } //LOAD ALL CLIENTS FROM DATABASE
        void LoadClientAddress()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id_address,address,city,country,zip FROM address WHERE id_client = '" + clientid_temp + "' ", con);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_address.DataSource = dt;
            con.Close();
            dgv_address.Columns["id_address"].HeaderText = "AddressID";
            dgv_address.Columns["address"].HeaderText = "Address";
            dgv_address.Columns["city"].HeaderText = "City";
            dgv_address.Columns["country"].HeaderText = "Country";
            dgv_address.Columns["zip"].HeaderText = "Zip-Code";
        } //LOAD CLIENTS ADDRESS FROM DATABASE
        void ClearTextBox()
        {
            txtbox_clientid.Clear();
            txtbox_password.Clear();
            txtbox_firstname.Clear();
            txtbox_lastname.Clear();
            cbbox_gender.Text = "";
            txtbox_birthday.Clear();
            txtbox_cellphone.Clear();
            txtbox_email.Clear();
            txtbox_addressid.Clear();
            txtbox_address.Clear();
            txtbox_country.Clear();
            txtbox_city.Clear();
            txtbox_zip_code.Clear();
        } //CLEAR ALL TEXTBOXS
        public void GetClientsInfo()
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
            if (string.IsNullOrEmpty(txtbox_birthday.Text))
            {
                birthday = "01/01/1900";
            }
            else
            {
                birthday = txtbox_birthday.Text;
            }
            cellphone = txtbox_cellphone.Text;
            email = txtbox_email.Text;
        } //SAVE CLIENT INFORMATION IN TEXTBOX TO STRINGS AND INTS
        void GetClientsAddressInfo()
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
               
        private void Clients_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            LoadClients();
            AutoComplete();
            clientid_temp = 0;
            addressid_temp = 0;
            new_address = 0;
            if (password_permission == 0)
            {
                txtbox_password.Enabled = false;
                txtbox_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearTextBox();

            Program.actual = new objetodefinidoporti( ()=>btn_cancel_Click(null, null) );


            tabControl1.SelectTab(new_edit_client);
        } //NEW CLIENT

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clientid_temp = 0;
            addressid_temp = 0;
            new_address = 0;
            ClearTextBox();
            gb_address.Enabled = false;
            con.Close();
            tabControl1.SelectTab(clients_list);
        } //CANCEL BUTTON

        private void btn_save_Click(object sender, EventArgs e)
        {
            GetClientsInfo();
            GetClientsAddressInfo();
            con.Open();
            if (txtbox_clientid.Text == "")
            {
                string sql_new = "INSERT INTO clients (password,first_name,last_name,gender,birthday,cellphone,email) VALUES ( '" + password + "' , '" + first_name + "' ,'" + last_name + "' ,'" + gender + "'  , '" + birthday + "' ,'" + cellphone + "', '" + email + "')";
                SqlCommand cmd = new SqlCommand(sql_new, con);
                cmd.ExecuteNonQuery();
                if (new_address == 1)
                {
                    string sql_id = "Select * from clients where id_client = (Select MAX(id_client) From clients)";
                    SqlCommand cmd1 = new SqlCommand(sql_id, con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        id_client = reader.GetInt32(0);
                    }
                    clientid_temp = id_client;
                    string sql_new_address = "INSERT INTO address (id_client,address,country,city,zip) VALUES ( '" + clientid_temp + "','" + address + "' ,'" + country + "', '" + city + "','" + zip + "') ";
                    SqlCommand cmd2 = new SqlCommand(sql_new_address, con);
                    cmd2.ExecuteNonQuery();
                    new_address = 0;
                }
            }
            else
            {
                string sql_edit = "UPDATE clients SET password = '" + password + "' ,first_name = '" + first_name + "',last_name = '" + last_name + "',gender = '" + gender + "',birthday = '" + birthday + "',cellphone = '" + cellphone + "',email = '" + email + "' WHERE id_client = '" + clientid_temp + "' ";
                SqlCommand cmd = new SqlCommand(sql_edit, con);
                cmd.ExecuteNonQuery();
                if (gb_address.Enabled == true)
                {
                    if (new_address == 1)
                    {
                        string sql_new_address = "INSERT INTO address (id_client,address,country,city,zip) VALUES ( '" + clientid_temp + "','" + address + "' ,'" + country + "', '" + city + "','" + zip + "') ";
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
                        MessageBox.Show("Error Saving existe client address");
                    }
                }
            }            
            gb_address.Enabled = false;
            btn_newaddress.Enabled = true;
            con.Close();
            MessageBox.Show("Client was be Saved succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClientAddress();
            LoadClients();
            ClearTextBox();
            AutoComplete();
            tabControl1.SelectTab(clients_list);
        } //SAVE CLIENT AND ADDRESS INFORMATION

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (clientid_temp == 0)
            {
                MessageBox.Show("Select a Client to Edit");
            }
            else
            {
                btn_newaddress.Enabled = true;                
                string sql_edit = "Select * FROM clients WHERE id_client = '" + clientid_temp + "'";
                SqlCommand cmd = new SqlCommand(sql_edit, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_client = reader.GetInt32(0);
                    password = reader.GetString(1);
                    first_name = reader.GetString(2);
                    last_name = reader.GetString(3);
                    gender = reader.GetString(4);
                    birthday = reader.GetString(5);
                    cellphone = reader.GetString(6);
                    email = reader.GetString(7);
                }
                txtbox_clientid.Text = Convert.ToString(id_client);
                txtbox_password.Text = password;
                txtbox_firstname.Text = first_name;
                txtbox_lastname.Text = last_name;
                cbbox_gender.Text = gender;
                txtbox_birthday.Text = birthday;
                txtbox_cellphone.Text = cellphone;
                txtbox_email.Text = email;
                con.Close();
                tabControl1.SelectTab(new_edit_client);
            }
        } //EDIT CLIENT AND LOAD INFORMATION

        private void dgv_clients_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            dgv_clients_list.Rows[Index].Selected = true;
            int selectedrowindex = dgv_clients_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_clients_list.Rows[selectedrowindex];
            clientid_temp = Convert.ToInt32(selectedRow.Cells["id_client"].Value);
            LoadClientAddress();
        } //LOAD CLIENTS INFORMATION

        private void dgv_address_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            dgv_address.Rows[Index].Selected = true;
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

        }  //LOAD ADDRESS INFORMATION

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (clientid_temp == 0)
            {
                MessageBox.Show("Select a Client to Delete");
            }
            else
            {
                if ((MessageBox.Show("Are you sure you want to delete this client?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    string delete_client = "DELETE FROM clients where id_client = '" + clientid_temp + "'";
                    string delete_client_address = "DELETE FROM address where id_client = '" + clientid_temp + "'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(delete_client_address, con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(delete_client, con);
                    cmd.ExecuteNonQuery();
                    clientid_temp = 0;
                    con.Close();
                    MessageBox.Show("Client was be deleted succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadClients();
            LoadClientAddress();
        }  //DELETE CLIENT AND ADDRESS

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

        } //ADD NEW ADDRESS

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
                    string delete_client_address = "DELETE FROM address where id_address = '" + addressid_temp + "'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(delete_client_address, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Address was be deleted succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
            LoadClientAddress();
        } //Button delete address

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_search.Text == "")
            {
                LoadClients();
            }
            else
            {
                string search = txtbox_search.Text;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * From clients WHERE first_name LIKE '" + search + "%' OR last_name LIKE '" + search + "%' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_clients_list.DataSource = dt;
                con.Close();
            }
        } //search by first and last name

        private void Clients_Leave(object sender, EventArgs e)
        {
            int tab = tabControl1.SelectedIndex;
            if (tab == 1)
            {
                if (MessageBox.Show("You want quit whiout save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Sentings dont save");
                }
                else
                {
                    MessageBox.Show("Sentings save");
                }
            }
        }
    }
}
