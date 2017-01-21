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
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
        }
        public int id_category { get; set; }
        public string category_name { get; set; }
        public string category_description { get; set; }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        void LoadCategorys()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            var list = new List<string>();
            string sql = "SELECT category FROM products_category";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            list.Add("");
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["category"]));
            }
            con.Close();
            cbbox_category.DataSource = new BindingSource(list, null);            
        } //LOAD CATEGORY NAME FROM DATABASE

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_category.Text))
            {
                toolTip1.Show("Please enter Category Name.", cbbox_category, 1000);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                category_name = cbbox_category.Text;
                category_description = txtbox_description.Text;
                string sql = "Select * FROM products_category WHERE category = '" + category_name + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string sql_update = "UPDATE products_category SET category_description = '" + category_description + "' WHERE category = '" + category_name + "'";
                    SqlCommand cmd2 = new SqlCommand(sql_update, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Category '" + category_name + "' updated succesfull! ");
                }
                else
                {
                    string sql_insert = "INSERT INTO products_category (category, category_description) VALUES ( '" + category_name + "','" + category_description + "')";
                    SqlCommand cmd3 = new SqlCommand(sql_insert, con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Category '" + category_name + "' was been created");
                }
                con.Close();
                btn_save.Text = "Save";
                LoadCategorys();
            }
        } //Button Save
        private void Category_Load(object sender, EventArgs e)
        {            
            LoadCategorys();
        }
        private void cbbox_category_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            txtbox_description.Clear();
            category_name = cbbox_category.Text;
            string sql = "Select * FROM products_category WHERE category = '" + category_name + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id_category = reader.GetInt32(0);
                    category_name = reader.GetString(1);
                    if (reader.IsDBNull(2))
                    {
                        category_description = "";
                    }
                    else
                    {
                        category_description = reader.GetString(2);
                    }
                }
                con.Close();
                txtbox_description.Text = category_description;
                btn_save.Text = "Update";
            }
        }  //Text Change 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbox_category.Text))
            {
                return;
            }
            else
            {
                category_name = cbbox_category.Text;
                if (MessageBox.Show("Are you sure you want to Delete '" + category_name + "' ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql_delete = "DELETE FROM products_category WHERE category = '" + category_name + "'";
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
                LoadCategorys();
            }
        } //Button Delete
    }
}
