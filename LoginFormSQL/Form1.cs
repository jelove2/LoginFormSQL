using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            logindbEntities context = new logindbEntities();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                var user = context.AdminLogins.Where(a => a.UserName.Equals(textBox1.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(textBox2.Text))
                    {
                        success s1 = new success();
                        s1.Show();
                    }
                    else
                    {
                        MessageBox.Show("password not correct");

                    }
                }
                else
                {
                    MessageBox.Show("Username not correct");
                }
            }
            else
            {
                MessageBox.Show("Username and password required");
            }
        }
    }
}
