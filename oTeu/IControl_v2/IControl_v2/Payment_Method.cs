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
    public partial class Payment_Method : UserControl
    {
        public Payment_Method()
        {
            InitializeComponent();
        }
        public int id_payment { get; set; }
        public string payment_name { get; set; }
        public string payment_description { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        private void Payment_Method_Load(object sender, EventArgs e)
        {
            LoadPaymentMethods();
        }
        void LoadPaymentMethods()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            var list = new List<string>();
            string sql = "SELECT payment_method FROM clients_payment_method";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            list.Add("");
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["payment_method"]));
            }
            con.Close();
            cbbox_payment_method.DataSource = new BindingSource(list, null);
        } //LOAD Payment Methods NAME FROM DATABASE
        private void cbbox_payment_method_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            txtbox_description.Clear();
            payment_name = cbbox_payment_method.Text;
            string sql = "Select * FROM clients_payment_method WHERE payment_method = '" + payment_name + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_payment = reader.GetInt32(0);
                    payment_name = reader.GetString(1);
                    if (reader.IsDBNull(2))
                    {
                        payment_description = "";
                    }
                    else
                    {
                        payment_description = reader.GetString(2);
                    }                                    
                }
                con.Close();
                txtbox_description.Text = payment_description;
                btn_save.Text = "Update";                
            }            
        } //AUTO FILL DATA WHEN TEXT CHANGE
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_payment_method.Text))
            {
                toolTip1.Show("Please enter Permission Name.", cbbox_payment_method, 1000);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                payment_name = cbbox_payment_method.Text;
                payment_description = txtbox_description.Text;
                string sql = "Select * FROM clients_payment_method WHERE payment_method = '" + payment_name + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string sql_update = "UPDATE clients_payment_method SET payment_description = '" + payment_description + "' WHERE payment_method = '" + payment_name + "'";
                    SqlCommand cmd2 = new SqlCommand(sql_update, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Payment Method '" + payment_name + "' updated succesfull! ");
                }
                else
                {
                    string sql_insert = "INSERT INTO clients_payment_method (payment_method, payment_description) VALUES ( '" + payment_name + "','" + payment_description + "')";
                    SqlCommand cmd3 = new SqlCommand(sql_insert, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Payment Method '" + payment_name + "' was been created");
                }
                con.Close();
                btn_save.Text = "Save";
                LoadPaymentMethods();
            }
        }  //SAVE BUTTON
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_payment_method.Text))
            {
                return;
            }
            else
            {
                payment_name = cbbox_payment_method.Text;
                if (MessageBox.Show("Are you sure you want to Delete '" + payment_name + "' ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql_delete = "DELETE FROM clients_payment_method WHERE payment_method = '" + payment_name + "'";
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand(sql_delete, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this Payment Method while it is in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                LoadPaymentMethods();
            }
        } //DELETE BUTTON
    }
}
