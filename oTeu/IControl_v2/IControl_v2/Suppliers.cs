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
    public partial class Suppliers : UserControl
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public string supplier_email { get; set; }
        public string supplier_cellphone { get; set; }

        public int address_id { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public int new_address { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        private void new_edit_supplier_Click(object sender, EventArgs e)
        {

        }

        private void dgv_address_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            loadsuppliers();
            supplier_id = 0;
            address_id = 0;
        }

        void loadsuppliers()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id_supplier, supplier_name, supplier_email, supplier_cellphone FROM products_suppliers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_suppliers_list.DataSource = dt;
            con.Close();
            dgv_suppliers_list.Columns["id_supplier"].HeaderText = "SupplierID";
            dgv_suppliers_list.Columns["supplier_name"].HeaderText = "Name";
            dgv_suppliers_list.Columns["supplier_email"].HeaderText = "Email";
            dgv_suppliers_list.Columns["supplier_cellphone"].HeaderText = "Cellphone";
        } //Load Suppliers from database
        void Edit_supplier()
        {
            string sql_load = "SELECT supplier_name, supplier_email, supplier_cellphone FROM products_suppliers WHERE id_supplier = '" + supplier_id + "'";
            SqlCommand cmd = new SqlCommand(sql_load, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                supplier_name = reader.GetString(0);
                if (reader.IsDBNull(1))
                {
                    supplier_email = "";
                }
                else
                {
                    supplier_email = reader.GetString(1);
                }

                supplier_cellphone = reader.GetString(2);
            }
            txtbox_supplierid.Text = Convert.ToString(supplier_id);
            txtbox_name.Text = supplier_name;
            txtbox_email.Text = supplier_email;
            txtbox_cellphone.Text = supplier_cellphone;

        } //Load data from selected supplier
        void LoadAddress()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id_address, address, city, country, zip FROM address WHERE id_supplier = '" + supplier_id + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_address.DataSource = dt;
            con.Close();
            dgv_address.Columns["id_address"].HeaderText = "AddressID";
            dgv_address.Columns["address"].HeaderText = "Address";
            dgv_address.Columns["city"].HeaderText = "City";
            dgv_address.Columns["country"].HeaderText = "Country";
            dgv_address.Columns["zip"].HeaderText = "Zip-Code";
        } //Load all address from selected supplier
        void loadselectedaddress()
        {
            string sql_load = "SELECT address, city, country, zip FROM address WHERE id_address = '" + address_id + "'";
            SqlCommand cmd = new SqlCommand(sql_load, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                address = reader.GetString(0);
                city = reader.GetString(1);
                country = reader.GetString(2);
                zip = reader.GetString(3);
            }
            txtbox_addressid.Text = Convert.ToString(address_id);
            txtbox_address.Text = address;
            txtbox_country.Text = country;
            txtbox_city.Text = city;
            txtbox_zip_code.Text = zip;
            con.Close();
        }  //Load data from selected address
        void SupplierInformation()
        {
            if (txtbox_supplierid.Text != "")
            {
                supplier_id = Convert.ToInt32(txtbox_supplierid.Text);
            }
            supplier_name = txtbox_name.Text;
            supplier_cellphone = txtbox_cellphone.Text;
            supplier_email = txtbox_email.Text;
            if (txtbox_addressid.Text != "")
            {
                address_id = Convert.ToInt32(txtbox_addressid.Text);
            }
            address = txtbox_address.Text;
            country = txtbox_country.Text;
            city = txtbox_city.Text;
            zip = txtbox_zip_code.Text;
        } //Get data to save
        void cleartextbox()
        {
            txtbox_supplierid.Clear();
            txtbox_name.Clear();
            txtbox_cellphone.Clear();
            txtbox_email.Clear();
            txtbox_addressid.Clear();
            txtbox_address.Clear();
            txtbox_country.Clear();
            txtbox_city.Clear();
            txtbox_zip_code.Clear();
        } //Clear all data
        private void btn_newaddress_Click(object sender, EventArgs e)
        {
            gp_address.Enabled = true;
            dgv_address.Enabled = false;
            new_address = 1;
            btn_editaddress.Enabled = false;
            btn_deleteaddress.Enabled = false;
            btn_newaddress.Enabled = false;
        } // New Address

        private void btn_new_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(new_edit_supplier);
        } //Add new Supplier

        private void dgv_suppliers_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv_suppliers_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_suppliers_list.Rows[selectedrowindex];
            supplier_id = Convert.ToInt32(selectedRow.Cells["id_supplier"].Value);
        } //Select Supplier

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (supplier_id == 0)
            {
                MessageBox.Show("Select a Supplier to Edit");
            }
            else
            {
                Edit_supplier();
                LoadAddress();
                tabControl1.SelectTab(new_edit_supplier);
            }
        } //Button edit supplier

        private void dgv_address_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgv_address.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_address.Rows[selectedrowindex];
            address_id = Convert.ToInt32(selectedRow.Cells["id_address"].Value);
            loadselectedaddress();
        } //select address to edit

        private void btn_editaddress_Click(object sender, EventArgs e)
        {
            if (address_id == 0)
            {
                MessageBox.Show("Select a address to edit");
            }
            else
            {
                btn_editaddress.Enabled = false;
                btn_deleteaddress.Enabled = false;
                btn_newaddress.Enabled = false;
                gp_address.Enabled = true;
                dgv_address.Enabled = false;
            }
        } //Button edit address

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to cancel all?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_address.Enabled = true;
                gp_address.Enabled = false;
                loadsuppliers();
                cleartextbox();
                supplier_id = 0;
                address_id = 0;
                btn_editaddress.Enabled = true;
                btn_deleteaddress.Enabled = true;
                btn_newaddress.Enabled = true;
                tabControl1.SelectTab(suppliers_list);
            }
        } //Cancel Button

        private void btn_save_Click(object sender, EventArgs e)
        {
            SupplierInformation();
            con.Open();
            if (txtbox_supplierid.Text == "")
            {
                string sql_new = "INSERT INTO products_suppliers(supplier_name, supplier_cellphone, supplier_email) VALUES('" + supplier_name + "', '" + supplier_cellphone + "', '" + supplier_email + "')";
                SqlCommand cmd = new SqlCommand(sql_new, con);
                cmd.ExecuteNonQuery();
                if (new_address == 1)
                {
                    string sql_id = "Select * from products_suppliers where id_supplier = (Select MAX(id_supplier) From products_supplier)";
                    SqlCommand cmd1 = new SqlCommand(sql_id, con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        supplier_id = reader.GetInt32(0);
                    }
                    string sql_new_address = "INSERT INTO address (id_supplier,address,country,city,zip) VALUES ( '" + supplier_id + "','" + address + "' ,'" + country + "', '" + city + "','" + zip + "') ";
                    SqlCommand cmd2 = new SqlCommand(sql_new_address, con);
                    cmd2.ExecuteNonQuery();
                    new_address = 0;
                }
            }
            else
            {
                string sql_edit = "UPDATE products_suppliers SET supplier_name = '" + supplier_name + "' ,supplier_cellphone = '" + supplier_cellphone + "',supplier_email = '" + supplier_email + "' WHERE id_supplier = '" + supplier_id + "' ";
                SqlCommand cmd = new SqlCommand(sql_edit, con);
                cmd.ExecuteNonQuery();
                if (gp_address.Enabled == true)
                {
                    if (new_address == 1)
                    {
                        string sql_new_address = "INSERT INTO address (id_supplier,address,country,city,zip) VALUES ( '" + supplier_id + "','" + address + "' ,'" + country + "', '" + city + "','" + zip + "') ";
                        SqlCommand cmd2 = new SqlCommand(sql_new_address, con);
                        cmd2.ExecuteNonQuery();
                        new_address = 0;
                    }
                    else if (txtbox_addressid.Text != "")
                    {
                        string sql_edit_address = "UPDATE address SET address = '" + address + "' ,country = '" + country + "',city = '" + city + "',zip = '" + zip + "' WHERE id_address =  '" + address_id + "' ";
                        SqlCommand cmd2 = new SqlCommand(sql_edit_address, con);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving existe client address");
                    }
                }
            }
            con.Close();
            dgv_address.Enabled = true;
            gp_address.Enabled = false;
            loadsuppliers();
            cleartextbox();
            supplier_id = 0;
            address_id = 0;
            btn_editaddress.Enabled = true;
            btn_deleteaddress.Enabled = true;
            btn_newaddress.Enabled = true;
            tabControl1.SelectTab(suppliers_list);
            MessageBox.Show("Supplier was be Saved succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Save Button

        private void btn_deleteaddress_Click(object sender, EventArgs e)
        {
            if (address_id == 0)
            {
                MessageBox.Show("Select a Address to Delete");
            }
            else
            {
                if ((MessageBox.Show("Are you sure you want to delete this Address?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    string delete_client_address = "DELETE FROM address where id_address = '" + address_id + "'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(delete_client_address, con);
                    cmd1.ExecuteNonQuery();
                    LoadAddress();
                    MessageBox.Show("Address was be deleted succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        } //Button Delete Address

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (supplier_id == 0)
            {
                MessageBox.Show("Select a Supplier to Delete");
            }
            else
            {
                if ((MessageBox.Show("Are you sure you want to delete this Supplier?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    string delete_supplier = "DELETE FROM products_suppliers where id_supplier = '" + supplier_id + "'";
                    string delete_supplier_address = "DELETE FROM address where id_supplier = '" + supplier_id + "'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(delete_supplier_address, con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(delete_supplier, con);
                    cmd.ExecuteNonQuery();
                    supplier_id = 0;
                    con.Close();
                    MessageBox.Show("Supplier has been deleted successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadsuppliers();
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // Delete Supplier Button

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_search.Text == "")
            {
                loadsuppliers();
            }
            else
            {
                string search = txtbox_search.Text;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_supplier,supplier_name,supplier_cellphone,supplier_email FROM products_suppliers WHERE supplier_name LIKE '" + search + "%' OR id_supplier LIKE '" + search + "%' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_suppliers_list.DataSource = dt;
                con.Close();
            }
        } //Search Suppliers

        private void Suppliers_Leave(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == new_edit_supplier)
            {
                MessageBox.Show("queres sair");
                return;
            }                         
        }
    }
}
