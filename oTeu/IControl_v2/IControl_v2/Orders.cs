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
    public partial class Orders : UserControl
    {
        public int clientid_temp { get; set; }
        public int productid_temp { get; set; }
        public string productname_temp { get; set; }
        public string productprice_temp { get; set; }
        public int product_quantity_temp { get; set; }
        public int id_orders_details_temp { get; set; }
        public int stock_temp { get; set; }
        public int orderid { get; set; }
        public int clientid { get; set; }
        public int userid { get; set; }
        public int id_payment { get; set; }
        DateTime order_start_date { get; set; }
        DateTime order_end_date { get; set; }
        public int id_payment_status { get; set; }
        public int id_delivery_status { get; set; }
        public int id_purchase_status { get; set; }
        public string total_price { get; set; }
        public int old_quantity_value { get; set; }
        public int new_quantity_value { get; set; }
        DataTable dtproducts = new DataTable();
        DataTable deletedproducts = new DataTable();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);
        public Orders()
        {
            InitializeComponent();
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            LoadOrders();
            Loadclients();
            LoadProducts();
            LoadPaymentsMethod();
            LoadStatus();
            createproducttable();
            createdeletedproductstable();
        }
        void LoadOrders()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select id_order, id_client, total_price, payment_status, delivery_status, purchase_status FROM clients_orders", con);
            DataTable dt = new DataTable();
            DataColumn dataColumn = new DataColumn("payment_status");
            DataColumn dataColumn2 = new DataColumn("delivery_status");
            DataColumn dataColumn3 = new DataColumn("purchase_status");
            dataColumn.DataType = typeof(String);
            dataColumn2.DataType = typeof(String);
            dataColumn3.DataType = typeof(String);
            dt.Columns.Add(dataColumn);
            dt.Columns.Add(dataColumn2);
            dt.Columns.Add(dataColumn3);
            sda.Fill(dt);
            dt.Columns["id_order"].SetOrdinal(0);
            dt.Columns["id_client"].SetOrdinal(1);
            dt.Columns["total_price"].SetOrdinal(2);
            dt.Columns["payment_status"].SetOrdinal(3);
            dt.Columns["delivery_status"].SetOrdinal(4);
            dt.Columns["purchase_status"].SetOrdinal(5);
            dgv_orders_list.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string stats = dt.Rows[i]["payment_status"].ToString();
                string status_name = "";
                string sql = "SELECT order_status_name FROM orders_status WHERE id_orders_status = '" + stats + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    status_name = reader.GetString(0);
                }
                dt.Rows[i]["payment_status"] = status_name;
                stats = dt.Rows[i]["delivery_status"].ToString();
                string sql2 = "SELECT order_status_name FROM orders_status WHERE id_orders_status = '" + stats + "' ";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    status_name = reader2.GetString(0);
                }
                dt.Rows[i]["delivery_status"] = status_name;
                stats = dt.Rows[i]["purchase_status"].ToString();
                string sql3 = "SELECT order_status_name FROM orders_status WHERE id_orders_status = '" + stats + "' ";
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                SqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    status_name = reader3.GetString(0);
                }
                dt.Rows[i]["purchase_status"] = status_name;
            }
            dgv_orders_list.DataSource = dt;
            con.Close();
            dgv_orders_list.Columns["id_order"].HeaderText = "OrderID";
            dgv_orders_list.Columns["id_client"].HeaderText = "ClientID";
            dgv_orders_list.Columns["total_price"].HeaderText = "Total Order";
            dgv_orders_list.Columns["payment_status"].HeaderText = "Payment Status";
            dgv_orders_list.Columns["delivery_status"].HeaderText = "Delivery";
            dgv_orders_list.Columns["purchase_status"].HeaderText = "Purchase";
        }  //LOAD ORDERS FROM DATABASE
        void Loadclients()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select id_client,first_name,last_name,cellphone,email From clients ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_clients_list.DataSource = dt;
            con.Close();
            dgv_clients_list.Columns["id_client"].HeaderText = "ClientID";
            dgv_clients_list.Columns["first_name"].HeaderText = "First Name";
            dgv_clients_list.Columns["last_name"].HeaderText = "Last Name";
            dgv_clients_list.Columns["cellphone"].HeaderText = "Cellphone Number";
            dgv_clients_list.Columns["email"].HeaderText = "Email";
            dgv_clients_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }  //LOAD CLIENTS STORAGE IN DATABASE
        void LoadProducts()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.products.id_product, dbo.products.product_name,dbo.products_category.category, dbo.products.product_code, dbo.products.product_stock, dbo.products.product_price FROM dbo.products INNER JOIN dbo.products_category ON dbo.products.id_product_category = dbo.products_category.id_product_category ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_products_list.DataSource = dt;
            con.Close();
            dgv_products_list.Columns["id_product"].HeaderText = "ProductID";
            dgv_products_list.Columns["product_name"].HeaderText = "Product Name";
            dgv_products_list.Columns["category"].HeaderText = "Category";
            dgv_products_list.Columns["product_code"].HeaderText = "Product Code";
            dgv_products_list.Columns["product_stock"].HeaderText = "Stock";
            dgv_products_list.Columns["product_price"].HeaderText = "Price";
            dgv_products_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }  //LOAD PRODUCTS FROM DATABASE
        void LoadPaymentsMethod()
        {
            var list = new List<string>();
            string sql = "SELECT payment_method FROM clients_payment_method ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var reader = cmd.ExecuteReader();
            list.Add("SELECT");
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["payment_method"]));
            }
            cbbox_payment.DataSource = new BindingSource(list, null);
            con.Close();
        }  //LOAD PAYMENT METHOD FROM DATABASE
        void LoadStatus()
        {
            var list = new List<string>();
            string sql = "SELECT order_status_name FROM orders_status ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Convert.ToString(reader["order_status_name"]));
            }
            cbbox_purchasestatus.DataSource = new BindingSource(list, null);
            cbbox_paymentstatus.DataSource = new BindingSource(list, null);
            cbbox_deliverystaus.DataSource = new BindingSource(list, null);
            con.Close();
        }  //LOAD ORDER STATUS FROM DATABASE
        void GetOrder()
        {
            clientid = Convert.ToInt32(txtbox_clientid.Text);
            userid = Convert.ToInt32(txtbox_userid.Text);
            order_start_date = Convert.ToDateTime(txtbox_start_order.Text);
            order_end_date = System.DateTime.Now;
            total_price = txtbox_totalprice.Text;
            GetPaymentMethod();
            GetPurchaseStatus();
            GetDeliveryStatus();
            GetPaymentStatus();
        } //GET INFORMATION ABOUT ORDER
        void GetTotal()
        {
            double sum = 0;
            for (int i = 0; i < dgv_products.Rows.Count; ++i)
            {
                double d = 0;
                Double.TryParse(dgv_products.Rows[i].Cells["total_price"].Value.ToString(), out d);
                sum += d;
            }
            txtbox_totalprice.Text = sum.ToString();
        }  // GET TOTAL MONEY OF THE ORDER
        void GetPaymentMethod()
        {
            string paymentmethod = cbbox_payment.Text;
            string sql = "SELECT id_payment FROM clients_payment_method WHERE payment_method = '" + paymentmethod + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_payment = reader.GetInt32(0);
            }
            con.Close();
        }   //GET THE PAYMENT METHODE
        void GetPurchaseStatus()
        {
            string purchasestatus = cbbox_purchasestatus.Text;
            string sql = "SELECT id_orders_status FROM orders_status WHERE order_status_name = '" + purchasestatus + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_purchase_status = reader.GetInt32(0);
            }
            con.Close();
        }   //GET PURCHASE STATUS
        void GetDeliveryStatus()
        {
            string delivery_status = cbbox_deliverystaus.Text;
            string sql = "SELECT id_orders_status FROM orders_status WHERE order_status_name = '" + delivery_status + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_delivery_status = reader.GetInt32(0);
            }
            con.Close();
        } //GET DELIVERY STATUS
        void GetPaymentStatus()
        {
            string payment_status = cbbox_paymentstatus.Text;
            string sql = "SELECT id_orders_status FROM orders_status WHERE order_status_name = '" + payment_status + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id_payment_status = reader.GetInt32(0);
            }
            con.Close();
        } //GET PAYMENT STATUS
        void GetQuantityTotal()
        {
            for (int i = 0; i < dgv_products.Rows.Count; ++i)
            {
                Decimal cell1 = Convert.ToDecimal(dgv_products.Rows[i].Cells["product_price"].Value);
                Decimal cell2 = Convert.ToDecimal(dgv_products.Rows[i].Cells["product_quantity"].Value);
                if (cell1.ToString() != "" && cell2.ToString() != "")
                {
                    dgv_products.Rows[i].Cells["total_price"].Value = cell1 * cell2;
                }
            }
        }   //GET TOTAL OF THE PRODUCT
        void ChangeStock()  
        {
            if (new_quantity_value != old_quantity_value)
            {
                int selectedrowindex = dgv_products.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_products.Rows[selectedrowindex];
                con.Open();
                string sql_stock = "Select product_stock from products where id_product = '" + productid_temp + "'";
                SqlCommand cmd1 = new SqlCommand(sql_stock, con);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    stock_temp = reader.GetInt32(0);
                }
                con.Close();
                int stock_total = stock_temp + old_quantity_value;
                if (new_quantity_value <= stock_total)
                {
                    if (new_quantity_value > old_quantity_value)
                    {
                        int remove = new_quantity_value - old_quantity_value;
                        int new_stock = stock_temp - remove;
                        con.Open();
                        string sql_new_stock = "UPDATE products SET product_stock = '" + new_stock + "' WHERE id_product = '" + productid_temp + "' ";
                        SqlCommand cmd = new SqlCommand(sql_new_stock, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (new_quantity_value < old_quantity_value)
                    {
                        int add = old_quantity_value - new_quantity_value;
                        int new_stock = stock_temp + add;
                        con.Open();
                        string sql_new_stock = "UPDATE products SET product_stock = '" + new_stock + "' WHERE id_product = '" + productid_temp + "' ";
                        SqlCommand cmd = new SqlCommand(sql_new_stock, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Stock, only Available: " + stock_total + " ");
                    selectedRow.Cells["product_quantity"].Value = (old_quantity_value);
                    GetQuantityTotal();
                    GetTotal();
                }
            }

        } // CHANGE STOCK IN DATABASE
        void AddProduct()
        {
            DataRow row = dtproducts.NewRow();
            row["id_orders_details"] = id_orders_details_temp;
            row["id_product"] = productid_temp;
            row["product_name"] = productname_temp;
            row["product_price"] = productprice_temp;
            row["product_quantity"] = product_quantity_temp;
            dtproducts.Rows.Add(row);
            dtproducts.AcceptChanges();
            dgv_products.DataSource = dtproducts;
        } //Add products to order
        void createproducttable()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.clients_orders_details.id_orders_details, dbo.clients_orders_details.id_product, dbo.products.product_name, dbo.products.product_price, dbo.clients_orders_details.product_quantity FROM dbo.clients_orders INNER JOIN dbo.clients_orders_details ON dbo.clients_orders.id_order = dbo.clients_orders_details.id_order INNER JOIN dbo.products ON dbo.clients_orders_details.id_product = dbo.products.id_product WHERE dbo.clients_orders.id_order =  0", con);
            sda.Fill(dtproducts);
            dgv_products.DataSource = dtproducts;
            con.Close();
            dgv_products.Columns["id_orders_details"].HeaderText = "ID";
            dgv_products.Columns["id_orders_details"].ReadOnly = true;
            dgv_products.Columns["id_product"].HeaderText = "ProductID";
            dgv_products.Columns["id_product"].ReadOnly = true;
            dgv_products.Columns["product_name"].HeaderText = "Product Name";
            dgv_products.Columns["product_name"].ReadOnly = true;
            dgv_products.Columns["product_price"].HeaderText = "Price";
            dgv_products.Columns["product_price"].ReadOnly = true;
            dgv_products.Columns["product_quantity"].HeaderText = "Quantity";
            dgv_products.Columns.Add("total_price", "Total");
            dgv_products.Columns["total_price"].ReadOnly = true;
        } // Create table to load from database
        void createdeletedproductstable()
        {
            DataColumn dataColumn = new DataColumn("old_quantity_value");
            DataColumn dataColumn2 = new DataColumn("productid_temp");
            DataColumn dataColumn3 = new DataColumn("product_name");
            DataColumn dataColumn4 = new DataColumn("product_price");
            DataColumn dataColumn5 = new DataColumn("id_orders_details");
            dataColumn.DataType = typeof(Int32);
            dataColumn2.DataType = typeof(Int32);
            dataColumn3.DataType = typeof(String);
            dataColumn4.DataType = typeof(String);
            dataColumn5.DataType = typeof(Int32);
            deletedproducts.Columns.Add(dataColumn);
            deletedproducts.Columns.Add(dataColumn2);
            deletedproducts.Columns.Add(dataColumn3);
            deletedproducts.Columns.Add(dataColumn4);
            deletedproducts.Columns.Add(dataColumn5);
        } //create a temporary table to store deleted products from order

        void Load_paymentmethod_selectedorder()
        {
            string sql = "SELECT payment_method FROM clients_payment_method WHERE id_payment = '" + id_payment + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbox_payment.Text = reader.GetString(0);
            }
            con.Close();
        } //Load Paymenth from selected order
        void Load_purchasestatus_selectedorder()
        {
            string sql = "SELECT order_status_name FROM orders_status WHERE id_orders_status = '" + id_purchase_status + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbox_purchasestatus.Text = reader.GetString(0);
            }
            con.Close();
        } //Load purchase status  from selected order
        void Load_paymentstatus_selectedorder()
        {
            string sql = "SELECT order_status_name FROM orders_status WHERE id_orders_status = '" + id_payment_status + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbox_paymentstatus.Text = reader.GetString(0);
            }
            con.Close();
        } //Load payment status  from selected order
        void Load_deliverystatus_selectedorder()
        {
            string sql = "SELECT order_status_name FROM orders_status WHERE id_orders_status = '" + id_delivery_status + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbox_deliverystaus.Text = reader.GetString(0);
            }
            con.Close();
        } //Load delivery status from selected order
        void Load_products_selectedorder()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.clients_orders_details.id_orders_details, dbo.clients_orders_details.id_product, dbo.products.product_name, dbo.products.product_price, dbo.clients_orders_details.product_quantity FROM dbo.clients_orders INNER JOIN dbo.clients_orders_details ON dbo.clients_orders.id_order = dbo.clients_orders_details.id_order INNER JOIN dbo.products ON dbo.clients_orders_details.id_product = dbo.products.id_product WHERE dbo.clients_orders.id_order =  '" + orderid + "'", con);
            sda.Fill(dtproducts);
            dgv_products.DataSource = dtproducts;
            con.Close();
        } //Load products  from selected order

        private void dgv_clients_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv_clients_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_clients_list.Rows[selectedrowindex];
            clientid_temp = Convert.ToInt32(selectedRow.Cells["id_client"].Value);
        }//GET CLIENTID
        private void btn_select_client_Click(object sender, EventArgs e)
        {
            txtbox_clientid.Text = Convert.ToString(clientid_temp);
            tabControl1.SelectTab(new_edit_order);
        } //SELECT CLIENT TO ORDER
        private void btn_cancel_client_Click(object sender, EventArgs e)
        {
            clientid_temp = 0;
            tabControl1.SelectTab(new_edit_order);
        } //CANCEL TO SELECT CLIENT
        private void txtbox_search_client_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_search_client.Text == "")
            {
                Loadclients();
            }
            else
            {
                string search = txtbox_search_client.Text;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_client,first_name,last_name,cellphone,email FROM clients WHERE first_name LIKE '" + search + "%' OR last_name LIKE '" + search + "%' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_clients_list.DataSource = dt;
                con.Close();
            }
        } // FILTER CLIENTS BY NAME
        private void txtbox_search_products_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_search_products.Text == "")
            {
                LoadProducts();
            }
            else
            {
                string search = txtbox_search_products.Text;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.products.id_product, dbo.products.product_name,dbo.products_category.category, dbo.products.product_code, dbo.products.product_stock, dbo.products.product_price FROM dbo.products INNER JOIN dbo.products_category ON dbo.products.id_product_category = dbo.products_category.id_product_category WHERE dbo.products.product_name LIKE '" + search + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_products_list.DataSource = dt;
                con.Close();
            }
        } //FILTER PRODUCTS BY NAME
        private void btn_add_product_Click(object sender, EventArgs e)
        {
            if (txtbox_clientid.Text == "0" || txtbox_clientid.Text == "")
            {
                MessageBox.Show("Select a Client first");
            }
            else
            {
                LoadProducts();
                for (int product = 0; product < dgv_products.Rows.Count; ++product)
                {
                    string id_product = dgv_products.Rows[product].Cells["id_product"].Value.ToString();
                    for (int list = 0; list < dgv_products_list.Rows.Count; ++list)
                    {
                        string id_product_list = dgv_products_list.Rows[list].Cells["id_product"].Value.ToString();
                        if (id_product_list == id_product)
                        {
                            dgv_products_list.Rows.RemoveAt(list);
                        }
                    }
                }
                tabControl1.SelectTab(select_product);
            }
        } //WARNING TO SELECT A CLIENT FIRST IF NOT SELECTED    
        private void btn_select_product_Click(object sender, EventArgs e)
        {
            id_orders_details_temp = 0;
            product_quantity_temp = 1;
            AddProduct();
            con.Open();
            string sql_stock = "Select product_stock from products where id_product = '" + productid_temp + "'";
            SqlCommand cmd1 = new SqlCommand(sql_stock, con);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                stock_temp = reader.GetInt32(0);
            }
            int new_stock = stock_temp - 1;
            string sql_new_stock = "UPDATE products SET product_stock = '" + new_stock + "' WHERE id_product = '" + productid_temp + "' ";
            SqlCommand cmd = new SqlCommand(sql_new_stock, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GetTotal();
            tabControl1.SelectTab(new_edit_order);
        } //ADD PRODUCT TO ORDER AND CHANGE STOCK
        private void dgv_products_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv_products_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_products_list.Rows[selectedrowindex];
            productid_temp = Convert.ToInt32(selectedRow.Cells["id_product"].Value);
            int selectedrowindex2 = dgv_products_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow2 = dgv_products_list.Rows[selectedrowindex];
            productname_temp = Convert.ToString(selectedRow.Cells["product_name"].Value);
            int selectedrowindex3 = dgv_products_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow3 = dgv_products_list.Rows[selectedrowindex];
            productprice_temp = Convert.ToString(selectedRow.Cells["product_price"].Value);
        }  //GET DATA FROM SELECTED PRODUCT
        private void dgv_products_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GetQuantityTotal();
            GetTotal();
            int selectedrowindex = dgv_products.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_products.Rows[selectedrowindex];
            new_quantity_value = Convert.ToInt32(selectedRow.Cells["product_quantity"].Value);
            ChangeStock();
        } //CHANGE STOCK IN DATABASE
        private void btn_cancel_product_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(new_edit_order);
        }   //CANCEL SELECT PRODUCT AND RETURN TO ORDER
        private void dgv_products_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GetQuantityTotal();
            GetTotal();
        }// GET TOTAL ORDER WHEN A PRODUCT IS ADDED
        private void btn_save_order_Click(object sender, EventArgs e)
        {
            GetOrder();
            if (txtbox_orderid.Text == "")
            {
                string sql_new = "INSERT INTO clients_orders (id_client, id_user, id_payment, total_price, date_order_start, date_order_end, payment_status, delivery_status, purchase_status) VALUES ('" + clientid + "',  '" + userid + "', '" + id_payment + "', '" + total_price + "', '" + order_start_date + "', '" + order_end_date + "', '" + id_payment_status + "', '" + id_delivery_status + "', '" + id_purchase_status + "' )";
                SqlCommand cmd = new SqlCommand(sql_new, con);
                con.Open();
                cmd.ExecuteNonQuery();
                string sql_id = "Select * from clients_orders where id_order = (Select MAX(id_order) From clients_orders)";
                SqlCommand cmd1 = new SqlCommand(sql_id, con);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    orderid = reader.GetInt32(0);
                }
                for (int i = 0; i < dgv_products.Rows.Count; i++)
                {
                    string id_product = dgv_products.Rows[i].Cells["id_product"].Value.ToString();
                    string product_quantity = dgv_products.Rows[i].Cells["product_quantity"].Value.ToString();
                    string sql_insert = "INSERT INTO clients_orders_details (id_order, id_product, product_quantity) VALUES ('" + orderid + "','" + id_product + "','" + product_quantity + "')";
                    SqlCommand cmd2 = new SqlCommand(sql_insert, con);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Order was been created!!");
            }
            else
            {
                orderid = Convert.ToInt32(txtbox_orderid.Text);
                string update = "UPDATE clients_orders SET id_payment = '" + id_payment + "', total_price = '" + total_price + "', date_order_end = '" + order_end_date + "', payment_status = '" + id_payment_status + "', delivery_status = '" + id_delivery_status + "', purchase_status = '" + id_purchase_status + "' WHERE id_order = '" + orderid + "' ";
                SqlCommand cmd = new SqlCommand(update, con);
                con.Open();
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dgv_products.Rows.Count; i++)
                {
                    int id_order_details = Convert.ToInt32(dgv_products.Rows[i].Cells["id_orders_details"].Value.ToString());
                    string id_product = dgv_products.Rows[i].Cells["id_product"].Value.ToString();
                    string product_quantity = dgv_products.Rows[i].Cells["product_quantity"].Value.ToString();
                    if (id_order_details == 0)
                    {
                        string sql_insert = "INSERT INTO clients_orders_details (id_order, id_product, product_quantity) VALUES ('" + orderid + "','" + id_product + "','" + product_quantity + "')";
                        SqlCommand cmd2 = new SqlCommand(sql_insert, con);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        string update_products = "UPDATE clients_orders_details SET product_quantity = '" + product_quantity + "' WHERE id_orders_details = '" + id_order_details + "' ";
                        SqlCommand cmd3 = new SqlCommand(update_products, con);
                        cmd3.ExecuteNonQuery();
                    }
                    int delete;
                    for (int a = 0; a < deletedproducts.Rows.Count; a++)
                    {
                        delete = Convert.ToInt32(deletedproducts.Rows[a]["productid_temp"].ToString());
                        string sql_delete = "DELETE FROM clients_orders_details where id_order = '" + orderid + "' AND id_product = '" + delete + "' ";
                        SqlCommand cmd3 = new SqlCommand(sql_delete, con);
                        cmd3.ExecuteNonQuery();
                    }
                }
                con.Close();
                MessageBox.Show("Order was been Updated!!");
            }
            dtproducts.Clear();
            deletedproducts.Clear();
            txtbox_orderid.Clear();
            txtbox_clientid.Clear();
            txtbox_userid.Clear();
            cbbox_payment.Text = "SELECT";
            txtbox_start_order.Clear();
            txtbox_totalprice.Clear();
            txtbox_last_modification.Clear();
            cbbox_paymentstatus.Text = "SELECT";
            cbbox_deliverystaus.Text = "SELECT";
            cbbox_purchasestatus.Text = "SELECT";
            LoadOrders();
            tabControl1.SelectTab(orders_list);
            orderid = 0;
            clientid = 0;
            btn_browse_client.Enabled = true;
            txtbox_clientid.Enabled = true;
        }   //SAVE ORDER
        private void btn_delete_products_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to delete this product?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedrowindex = dgv_products.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_products.Rows[selectedrowindex];
                old_quantity_value = Convert.ToInt32(selectedRow.Cells["product_quantity"].Value);
                productid_temp = Convert.ToInt32(selectedRow.Cells["id_product"].Value);
                productname_temp = selectedRow.Cells["product_name"].Value.ToString();
                productprice_temp = selectedRow.Cells["product_price"].Value.ToString();
                id_orders_details_temp = Convert.ToInt32(selectedRow.Cells["id_orders_details"].Value);
                con.Open();
                string sql_stock = "Select product_stock from products where id_product = '" + productid_temp + "'";
                SqlCommand cmd1 = new SqlCommand(sql_stock, con);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    stock_temp = reader.GetInt32(0);
                }
                int new_stock = stock_temp + old_quantity_value;
                string sql_new_stock = "UPDATE products SET product_stock = '" + new_stock + "' WHERE id_product = '" + productid_temp + "' ";
                SqlCommand cmd = new SqlCommand(sql_new_stock, con);
                cmd.ExecuteNonQuery();
                con.Close();
                if (id_orders_details_temp == 0)
                {
                    dtproducts.Rows[selectedrowindex].Delete();
                    dtproducts.AcceptChanges();
                }
                else
                {
                    dtproducts.Rows[selectedrowindex].Delete();
                    dtproducts.AcceptChanges();
                    DataRow row = deletedproducts.NewRow();
                    row["id_orders_details"] = id_orders_details_temp;
                    row["old_quantity_value"] = old_quantity_value;
                    row["productid_temp"] = productid_temp;
                    row["product_name"] = productname_temp;
                    row["product_price"] = productprice_temp;
                    deletedproducts.Rows.Add(row);
                    deletedproducts.AcceptChanges();
                }
                dgv_products.DataSource = dtproducts;
            }
            GetTotal();
        }  //DELETE SELECTED PRODUCT FROM ORDER
        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv_products.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_products.Rows[selectedrowindex];
            old_quantity_value = Convert.ToInt32(selectedRow.Cells["product_quantity"].Value);
            productid_temp = Convert.ToInt32(selectedRow.Cells["id_product"].Value);
        }  // SAVE LAST STOCK VALUE AND PRODUCTID
        private void btn_cancel_order_Click(object sender, EventArgs e)
        {
            for (int restore = 0; restore < deletedproducts.Rows.Count; restore++)
            {
                productid_temp = Convert.ToInt32(deletedproducts.Rows[restore]["productid_temp"].ToString());
                product_quantity_temp = Convert.ToInt32(deletedproducts.Rows[restore]["old_quantity_value"].ToString());
                productname_temp = deletedproducts.Rows[restore]["product_name"].ToString();
                productprice_temp = deletedproducts.Rows[restore]["product_price"].ToString();
                id_orders_details_temp = Convert.ToInt32(deletedproducts.Rows[restore]["id_orders_details"].ToString());
                AddProduct();
            }
            int quantity_temp = 0;
            for (int i = 0; i < dgv_products.Rows.Count; i++)
            {
                int id_order = Convert.ToInt32(dgv_products.Rows[i].Cells["id_orders_details"].Value.ToString());
                productid_temp = Convert.ToInt32(dgv_products.Rows[i].Cells["id_product"].Value.ToString());
                old_quantity_value = Convert.ToInt32(dgv_products.Rows[i].Cells["product_quantity"].Value.ToString());

                if (id_order == 0)
                {
                    con.Open();
                    string sql_stock = "Select product_stock from products where id_product = '" + productid_temp + "'";
                    SqlCommand cmd1 = new SqlCommand(sql_stock, con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        stock_temp = reader.GetInt32(0);
                    }
                    int new_stock = stock_temp + old_quantity_value;
                    string sql_new_stock = "UPDATE products SET product_stock = '" + new_stock + "' WHERE id_product = '" + productid_temp + "' ";
                    SqlCommand cmd = new SqlCommand(sql_new_stock, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Open();
                    string sql_stock = "Select product_stock from products where id_product = '" + productid_temp + "'";
                    SqlCommand cmd1 = new SqlCommand(sql_stock, con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        stock_temp = reader.GetInt32(0);
                    }

                    string sql_select = "SELECT product_quantity FROM clients_orders_details WHERE id_orders_details = '" + id_order + "' ";
                    SqlCommand cmd2 = new SqlCommand(sql_select, con);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        quantity_temp = reader2.GetInt32(0);
                    }
                    int _stock = stock_temp + old_quantity_value;
                    int new_stock = _stock - quantity_temp;
                    string sql_new_stock = "UPDATE products SET product_stock = '" + new_stock + "' WHERE id_product = '" + productid_temp + "' ";
                    SqlCommand cmd = new SqlCommand(sql_new_stock, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            txtbox_orderid.Clear();
            txtbox_clientid.Clear();
            txtbox_userid.Clear();
            cbbox_payment.Text = "SELECT";
            txtbox_start_order.Clear();
            txtbox_last_modification.Clear();
            cbbox_paymentstatus.Text = "SELECT";
            cbbox_deliverystaus.Text = "SELECT";
            cbbox_purchasestatus.Text = "SELECT";
            LoadOrders();
            tabControl1.SelectTab(orders_list);
            txtbox_clientid.Enabled = true;
            orderid = 0;
            clientid = 0;
            btn_browse_client.Enabled = true;
            dtproducts.Clear();
            deletedproducts.Clear();
        }   //CANCEL BUTTON RESTORE THE ORDER
        private void btn_new_order_Click(object sender, EventArgs e)
        {
            txtbox_clientid.Enabled = true;


            Program.actual = new objetodefinidoporti(   );


            tabControl1.SelectTab(new_edit_order);
            txtbox_start_order.Text = System.DateTime.Now.ToString();
        } //OPEN TAB TO CREATE A NEW ORDER
        private void btn_edit_order_Click(object sender, EventArgs e)
        {
            txtbox_clientid.Enabled = false;
            if (orderid == 0)
            {
                MessageBox.Show("Select a order to edit.");
            }
            else
            {
                btn_browse_client.Enabled = false;
                con.Open();
                string sql_edit = "SELECT * FROM clients_orders WHERE id_order = '" + orderid + "' ";
                SqlCommand cmd1 = new SqlCommand(sql_edit, con);
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    clientid = reader.GetInt32(1);
                    userid = reader.GetInt32(2);
                    id_payment = reader.GetInt32(3);
                    total_price = reader.GetString(4);
                    order_start_date = reader.GetDateTime(5);
                    order_end_date = reader.GetDateTime(6);
                    if (reader.IsDBNull(7))
                    {
                        id_payment_status = 0;
                    }
                    else
                    {
                        id_payment_status = reader.GetInt32(7);
                    }
                    if (reader.IsDBNull(8))
                    {
                        id_delivery_status = 0;
                    }
                    else
                    {
                        id_delivery_status = reader.GetInt32(8);
                    }
                    if (reader.IsDBNull(9))
                    {
                        id_purchase_status = 0;
                    }
                    else
                    {
                        id_purchase_status = reader.GetInt32(9);
                    }
                }
                con.Close();
                txtbox_orderid.Text = Convert.ToString(orderid);
                txtbox_clientid.Text = Convert.ToString(clientid);
                txtbox_userid.Text = Convert.ToString(userid);
                txtbox_start_order.Text = Convert.ToString(order_start_date);
                txtbox_last_modification.Text = Convert.ToString(order_end_date);
                Load_paymentmethod_selectedorder();
                Load_purchasestatus_selectedorder();
                Load_paymentstatus_selectedorder();
                Load_deliverystatus_selectedorder();
                txtbox_totalprice.Text = Convert.ToString(total_price);
                Load_products_selectedorder();
                GetQuantityTotal();
                tabControl1.SelectTab(new_edit_order);
            }
        }    //LOAD DATA FROM SELECTED ORDER
        private void dgv_orders_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int Index = e.RowIndex;
            //dgv_orders_list.Rows[Index].Selected = true;
            int selectedrowindex = dgv_orders_list.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_orders_list.Rows[selectedrowindex];
            orderid = Convert.ToInt32(selectedRow.Cells["id_order"].Value);
        }   //SELECT ORDER TO EDIT

        void deleteorder()
        {
            if (orderid == 0)
            {
                MessageBox.Show("Select a Order to Delete");
            }
            else
            {
                if ((MessageBox.Show("Are you sure you want to delete this Order: '" + orderid + "' ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    string delete_order_details = "DELETE FROM clients_orders_details where id_order = '" + orderid + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(delete_order_details, con);
                    cmd.ExecuteNonQuery();
                    string delete_order = "DELETE FROM clients_orders WHERE id_order = '" + orderid + "' ";
                    SqlCommand cmd1 = new SqlCommand(delete_order, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Order was be deleted succesfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abort", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
            LoadOrders();
        }

        private void btn_browse_client_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(select_client);
        }
        private void txtbox_clientid_DoubleClick(object sender, EventArgs e)
        {
            if(txtbox_clientid.Enabled == true)
            {
                this.btn_browse_client_Click(null, null);
            }            
        }
    }
}
