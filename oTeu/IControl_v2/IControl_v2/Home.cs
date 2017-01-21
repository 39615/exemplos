using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IControl_v2
{
    public partial class Home : UserControl
    {
        public int userid { get; set; }
        public string permission_name { get; set; }

        public Home(int _userid, string _permission_name)
        {
            InitializeComponent();
            this.userid = _userid;
            this.permission_name = _permission_name;
        }


        void orders()
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            orders();
            label_userid.Text = "UserID: " + userid + "";
            label_permission.Text = "Permissions: " + permission_name + "";
        }
    }
}
