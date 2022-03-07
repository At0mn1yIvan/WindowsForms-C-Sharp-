using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_пользователей
{
    public partial class Cr_New_User : Form
    {
        public Cr_New_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Button
            bool IsUsExists = false;
            string Users_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\User.txt";
            string Password_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Password.txt";
            string Name_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Name.txt";
            string Surname_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Surname.txt";
            string Email_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Email.txt";

            string[] Users = File.ReadAllLines(Users_f);
            foreach (string User in Users)
            {
                if (User == textBox1.Text) {
                    IsUsExists = true;
                    break;
                }
                
            }

            if (IsUsExists)
            {
                toolStripStatusLabel1.Text = "A user with such username already exists";
                statusStrip1.Show();
            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                toolStripStatusLabel1.Text = "Input username";
                statusStrip1.Show();
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                toolStripStatusLabel1.Text = "Input password";
                statusStrip1.Show();
            }
            else if (textBox2.Text == textBox3.Text)
            {
                File.AppendAllText(Users_f, textBox1.Text + '\n');
                File.AppendAllText(Password_f, textBox2.Text + '\n');
                File.AppendAllText(Name_f, "Input Name\n");
                File.AppendAllText(Surname_f, "Input Surname\n");
                File.AppendAllText(Email_f, "Input Email\n");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                toolStripStatusLabel1.Text = "Passwords don't match";
                statusStrip1.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cancel Button
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Show CheckBox
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = (char)0;
                textBox3.PasswordChar = (char)0;
                checkBox1.Text = "Hide";
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
                checkBox1.Text = "Show";
            }
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
