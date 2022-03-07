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
    public partial class Authorization : Form
    {
        string[] User;
        string[] Password;
        string Users_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\User.txt";
        string Password_f = @"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Password.txt";

        public Authorization()
        {
            InitializeComponent();

            User = File.ReadAllLines(Users_f);
            Password = File.ReadAllLines(Password_f);
        }


        private void Create_B_Click(object sender, EventArgs e)
        {
            // Create user Button
            Cr_New_User new_U = new Cr_New_User();
            DialogResult result = new_U.ShowDialog();
            if (result == DialogResult.OK)
            {
                User = File.ReadAllLines(Users_f);
                Password = File.ReadAllLines(Password_f);
            }
        }

        private void OK_B_Click(object sender, EventArgs e)
        {
            // OK Button 
            bool IsUsExist = false;
            if (String.IsNullOrEmpty(textBox_User.Text) || String.IsNullOrEmpty(textBox_Password.Text))
            {
                toolStripStatusLabel1.Text = "Input your password and name";
                statusStrip1.Show();
            }
            else
            {
                for (int i = 0; i < User.Length; i++) {
                    if (User[i] == textBox_User.Text)
                    {
                        IsUsExist = true;
                        if (Password[i] == textBox_Password.Text)
                        {
                            statusStrip1.Hide();
                            User_info Us_inf = new User_info(this, i);
                            Us_inf.Show();
                        }

                        else
                        {
                            toolStripStatusLabel1.Text = "Wrong name or password";
                            statusStrip1.Show();
                        }
                        break;
                    }
                }

                if (!IsUsExist)
                {
                    toolStripStatusLabel1.Text = "This user doesn't exist";
                    statusStrip1.Show();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Exit_B_Click_1(object sender, EventArgs e)
        {
            // Exit Button
            this.Close();
        }

        private void Show_Hide_B_CheckedChanged_1(object sender, EventArgs e)
        {
            //Show CheckBox
            if (Show_Hide_B.Checked)
            {
                textBox_Password.PasswordChar = (char)0;
                Show_Hide_B.Text = "Hide";
            }
            else
            {
                textBox_Password.PasswordChar = '*';
                Show_Hide_B.Text = "Show";
            }
        }

        private void textBox_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
