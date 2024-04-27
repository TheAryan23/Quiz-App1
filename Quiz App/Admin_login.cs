using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class Admin_login : Form
    {
        public static string fk_ad;
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = textBox1.Text;
            string password = textBox2.Text;
            string user_db, password_db;

            returnclass rc = new returnclass();
            user_db = rc.scalerReturn("select COUNT(ad_id) from tb1_admin where ad_name = '"+user_name+"' ");

            if(user_db == null )
            {
                MessageBox.Show("no user found");
            }
            else
            {
                password = rc.scalerReturn("select ad_password from tb1_admin where ad_name= '"+user_name+"' ");

                if(password.Equals(password))
                {
                    fk_ad = rc.scalerReturn("select ad_id from tb1_admin where ad_name = '" + user_name + "' ");

                    Form2 f = new Form2();
                    f.Show();
                     
                }
                else
                {
                    MessageBox.Show("invalid password");
                }
            }
        }
    }
}
