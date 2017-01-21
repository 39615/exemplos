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
    public partial class MainMenu : Form
    {
        public int userid { get; set; }
        public int permission { get; set; }
        public string permission_name;
        public int menu_clients;
        public int menu_clients_password;
        public int menu_orders;
        public int menu_products;
        public int menu_suppliers;
        public int menu_users;
        public int menu_permission;
        public int menu_admin_settings;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);
        public MainMenu(int _userid, int _permission)
        {
            InitializeComponent();
            this.userid = _userid;
            this.permission = _permission;
        }

        void Standartmenucolor()
        {
            btn_home.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_clients.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_orders.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_products.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_suppliers.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_users.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_permission.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_settings.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_admin_settings.Normalcolor = Color.FromArgb(39, 42, 51);
        } //Set standart colors in buttons
        void GetUserName()
        {
            string fname = "First";
            string lname = "Last";
            string sql = "SELECT first_name, last_name from users where id_user = '" + userid + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fname = reader.GetString(0);
                lname = reader.GetString(1);
            }
            con.Close();
            btn_logout.Text = "Welcome,\n "+ fname +" "+ lname + "";
        } //Load User Name
        void Permission()
        {
            string sql_read_permission = "SELECT permission_name, menu_clients, menu_clients_password, menu_orders, menu_products, menu_suppliers, menu_users, menu_permission, menu_admin_settings FROM users_permissions WHERE id_permission = '" + permission + "'";
            SqlCommand cmd = new SqlCommand(sql_read_permission, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                permission_name = reader.GetString(0);
                menu_clients = reader.GetInt32(1);
                menu_clients_password = reader.GetInt32(2);
                menu_orders = reader.GetInt32(3);
                menu_products = reader.GetInt32(4);
                menu_suppliers = reader.GetInt32(5);
                menu_users = reader.GetInt32(6);
                menu_permission = reader.GetInt32(7);
                menu_admin_settings = reader.GetInt32(8);
            }
            con.Close();           
            if (menu_permission != 1)
            {
                btn_permission.Visible = false;
            }
            if (menu_clients != 1)
            {
                btn_clients.Visible = false;
            }
            if (menu_orders != 1)
            {
                btn_orders.Visible = false;
            }
            if (menu_products != 1)
            {
                btn_products.Visible = false;
            }
            if (menu_suppliers != 1)
            {
                btn_suppliers.Visible = false;
            }
            if (menu_users != 1)
            {
                btn_users.Visible = false;
            }
            if(menu_admin_settings != 1)
            {
                btn_admin_settings.Visible = false;
            }

        } //LOAD THE USER PERMISSION
        void CheckPanel()
        {
            switch (CurrentSceen)
            {
                case ApplicationScreens.Home:
                        MessageBox.Show("Home Menu");
                        return;
                case ApplicationScreens.Clients:
                        MessageBox.Show("Clients Menu");
                        return;
                case ApplicationScreens.Orders:
                        MessageBox.Show("Orders Menu");
                        return;

            }
        }
        private enum ApplicationScreens
        {
            Home,
            Clients,
            Orders,
            Products,
            Suppliers,
            Users,
            Permission,
            AdminSettings,
            Settings
        }

        private ApplicationScreens CurrentSceen = ApplicationScreens.Home;

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 160)
            {
                panel_menu.Width = 44;
            }
            else
            {
                panel_menu.Width = 160;
            }
        } //Resize Menu
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Permission();
            GetUserName();
            Standartmenucolor();
            btn_home.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Home userControl = new Home(userid, permission_name);
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        }
        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            //if( MessageBox.Show("You want Logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            this.Close();
            this.MainMenu_FormClosing(null, null);
                
            //}
        } //LogOut Button
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var login = new Login();
            login.Show();
        }
        private void btn_permission_Click(object sender, EventArgs e)
        {
            CurrentSceen = ApplicationScreens.Permission;
            Standartmenucolor();
            btn_permission.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Permission userControl = new Permission();
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        } //Load Permission Menu
        private void btn_clients_Click(object sender, EventArgs e)
        {
           // CheckPanel();
            CurrentSceen = ApplicationScreens.Clients;
            Standartmenucolor();
            btn_clients.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Clients userControl = new Clients(menu_clients_password);
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        } //Load Client Menu
        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            CurrentSceen = ApplicationScreens.Suppliers;
            Standartmenucolor();
            btn_suppliers.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Suppliers userControl = new Suppliers();
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        } //Load Supplier Menu
        private void panel_page_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btn_users_Click(object sender, EventArgs e)
        {
            CurrentSceen = ApplicationScreens.Users;
            Standartmenucolor();
            btn_users.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Users userControl = new Users();
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        }  //Load Users Menu
        private void btn_orders_Click(object sender, EventArgs e)
        {
            CurrentSceen = ApplicationScreens.Orders;
            Standartmenucolor();
            btn_orders.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Orders userControl = new Orders();
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        }
        private void btn_admin_settings_Click(object sender, EventArgs e)
        {
            CurrentSceen = ApplicationScreens.AdminSettings;
            Standartmenucolor();
            btn_admin_settings.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Admin_settings userControl = new Admin_settings();
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            CurrentSceen = ApplicationScreens.Settings;
            Standartmenucolor();
            btn_settings.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Settings userControl = new Settings(userid);
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        }
        private void btn_home_Click(object sender, EventArgs e)
        {

            if (Program.actual != null)
            {
                //definição da showBox


                Program.actual.sair();
            }               


            CurrentSceen = ApplicationScreens.Home;
            Standartmenucolor();
            btn_home.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_page.Controls.Clear();
            panel_page.Dock = DockStyle.Fill;
            Home userControl = new Home(userid, permission_name);
            userControl.Dock = DockStyle.Fill;
            panel_page.Controls.Add(userControl);
        }
    }
}
