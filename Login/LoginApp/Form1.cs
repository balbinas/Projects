using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(System.Object sender, System.EventArgs e)
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(textBox1.Text);
            //label1.Text = returnString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Set the maximum length of text in the control to eight.
            textBox2.MaxLength = 8;
            // Assign the asterisk to be the password character.
            textBox2.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /* private void checkBox1_CheckedChanged(object sender, EventArgs e)
         {
             if (checkBox1.Checked)
             {
                 //Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                 //Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
             }
             else
             {
              //   Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                // Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);

             }
           //  Response.Cookies["UserName"].Value = textBox1.Text.Trim();
            // Response.Cookies["Password"].Value = textBox2.Text.Trim();
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {
           //  bool bAutoShowPassword = CheckingForAutoLogin(textBoxUserName.Text.Trim());
     if(bAutoShowPassword)
     {
         //auto login is available, so you do:
         checkbox1.Checked = true;
         textBoxPassword.Text = GetUserPassword(textBoxUserName.Text.Trim());
         //set password to some other character, to make text not readable:
         textBoxPassword.PasswordChar = '*';
         //and if there is something else to do!!
         //but now it all set to login in correctly!
     }
         }

     }*/
    }
}
