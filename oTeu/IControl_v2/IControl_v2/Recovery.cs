using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IControl_v2
{
    public partial class Recovery : Form
    {
        public Recovery()
        {
            InitializeComponent();
        }
        public string email { get; set; }
        public string my_email = "sergiosebastiao2008@hotmail.com";
        public string my_password = "Sebastiao_149477643zz0";

        int userid;
        string first_name;
        string last_name;
        string new_password;

        public static string GenerateRandomCode(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }  //Generate a Random Password

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlconnection"].ConnectionString);

        void GetUserInfo()
        {
            email = txtbox_email.Text;
            string sql_get = "SELECT id_user, first_name,last_name FROM users WHERE email = '"+email+"'";
            SqlCommand cmd = new SqlCommand(sql_get, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userid = reader.GetInt32(0);
                    first_name = reader.GetString(1);
                    last_name = reader.GetString(2);
                }
                new_password = GenerateRandomCode(8);
                string sql_update = "UPDATE users SET password = '" + new_password + "' WHERE email = '" + email + "'";
                SqlCommand cmd1 = new SqlCommand(sql_update, con);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Incorrect Email.");
                con.Close();
                return;
            }
            con.Close();
        } //Get User and check email
        private void btn_recovery_Click(object sender, EventArgs e)
        {
            GetUserInfo();
            try
            {
                MailMessage objeto_mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtp.live.com";
                client.Timeout = 100000000;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(my_email, my_password);
                objeto_mail.From = new MailAddress(my_email);
                objeto_mail.To.Add(new MailAddress(email));
                objeto_mail.Subject = "Account Recovery";
                objeto_mail.Body = "Hello "+first_name+" " + last_name + ",\n\n Your Account Informations is: \n\n UserID: "+userid+"\n New Password:  " + new_password +" \n\n Login with new password and change it in Settings Menu,\n\n Regards Icontrol. ";
                client.Send(objeto_mail);
                MessageBox.Show("Check your Email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not send email\n\n" + ex.Message);
            }            
        }         //Button Send Informations
    }
}
