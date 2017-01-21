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
    public partial class Admin_settings : UserControl
    {
        public Admin_settings()
        {
            InitializeComponent();
        }

        void StandartColors()
        {
            btn_payment.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_purchase.Normalcolor = Color.FromArgb(39, 42, 51);
            btn_category.Normalcolor = Color.FromArgb(39, 42, 51);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            StandartColors();
            btn_payment.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_admin.Controls.Clear();
            Payment_Method userControl = new Payment_Method();
            userControl.Dock = DockStyle.Fill;
            panel_admin.Controls.Add(userControl);
        }
        private void btn_purchase_Click(object sender, EventArgs e)
        {
            StandartColors();
            btn_purchase.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_admin.Controls.Clear();
            Purchase_Status userControl = new Purchase_Status();
            userControl.Dock = DockStyle.Fill;
            panel_admin.Controls.Add(userControl);
        }
        private void btn_category_Click(object sender, EventArgs e)
        {
            StandartColors();
            btn_category.Normalcolor = Color.FromArgb(24, 25, 31);
            panel_admin.Controls.Clear();
            Category userControl = new Category();
            userControl.Dock = DockStyle.Fill;
            panel_admin.Controls.Add(userControl);
        }
    }
}
