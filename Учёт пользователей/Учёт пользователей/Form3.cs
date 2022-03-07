using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_пользователей
{
    public partial class User_info : Form
    {
        string[] Users;
        string[] Names;
        string[] Surname;
        string[] Email;
        int Current_user;
        Form form1;

        public User_info(Form form, int User)
        {
            Current_user = User;
            form1 = form;
            form.Hide();

            InitializeComponent();

            Users = File.ReadAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\User.txt");
            Names = File.ReadAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Name.txt");
            Surname = File.ReadAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Surname.txt");
            Email = File.ReadAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Email.txt");

            groupBox1.Text = "Information on " + Users[Current_user];
            textBox1.Text = Names[Current_user];
            textBox2.Text = Surname[Current_user];
            textBox3.Text = Email[Current_user];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit Button
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Logout Button
            form1.Show();
            this.Close();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Edit CheckBox 1
            textBox1.ReadOnly = !checkBox1.Checked;
            if (!checkBox1.Checked) {
                Names[Current_user] = textBox1.Text;
                File.WriteAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Name.txt", Names);
            }
        }

        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Edit CheckBox 2
            textBox2.ReadOnly = !checkBox2.Checked;
            if (!checkBox2.Checked)
            {
                Surname[Current_user] = textBox2.Text;
                File.WriteAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Surname.txt", Surname);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Edit CheckBox 3
            textBox3.ReadOnly = !checkBox3.Checked;
            if (!checkBox3.Checked)
            {
                Email[Current_user] = textBox3.Text;
                File.WriteAllLines(@"C:\Users\khram\OneDrive\Рабочий стол\Accounts\Email.txt", Email);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
