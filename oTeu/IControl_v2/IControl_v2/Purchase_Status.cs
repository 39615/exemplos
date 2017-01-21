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
    public partial class Purchase_Status : UserControl
    {
        public Purchase_Status()
        {
            InitializeComponent();
        }
        public int id_status { get; set; }
        public string status_name { get; set; }
        public string status_description { get; set; }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        void LoadStatus()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            var list = new List<string>();
            string sql = "SELECT order_status_name FROM orders_status";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            list.Add("");
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["order_status_name"]));
            }
            con.Close();
            cbbox_status.DataSource = new BindingSource(list, null);
        } //LOAD STATUS NAME FROM DATABASE

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_status.Text))
            {
                toolTip1.Show("Please enter Status Name.", cbbox_status, 1000);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                status_name = cbbox_status.Text;
                status_description = txtbox_description.Text;
                string sql = "Select * FROM orders_status WHERE order_status_name = '" + status_name + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string sql_update = "UPDATE orders_status SET order_status_description = '" + status_description + "' WHERE order_status_name = '" + status_name + "'";
                    SqlCommand cmd2 = new SqlCommand(sql_update, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Status '" + status_name + "' updated succesfull! ");
                }
                else
                {
                    string sql_insert = "INSERT INTO order_status (order_status_name, order_status_description) VALUES ( '" + status_name + "','" + status_description + "')";
                    SqlCommand cmd3 = new SqlCommand(sql_insert, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Status '" + status_name + "' was been created");
                }
                con.Close();
                btn_save.Text = "Save";
                LoadStatus();
            }
        }//Button Save
        private void cbbox_status_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            txtbox_description.Clear();
            status_name = cbbox_status.Text;
            string sql = "Select * FROM orders_status WHERE order_status_name = '" + status_name + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_status = reader.GetInt32(0);
                    status_name = reader.GetString(1);
                    status_description = reader.GetString(2);
                }
                con.Close();
                txtbox_description.Text = status_description;
                btn_save.Text = "Update";
            }
        }  //Text Change 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_status.Text))
            {
                return;
            }
            else
            {
                status_name = cbbox_status.Text;
                if (MessageBox.Show("Are you sure you want to Delete '" + status_name + "' ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql_delete = "DELETE FROM orders_status WHERE category = '" + status_name + "'";
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand(sql_delete, con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this category while it is in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                LoadStatus();
            }
        }  //Button Delete
        private void Purchase_Status_Load(object sender, EventArgs e)
        {
            LoadStatus();
        }
    }
}
