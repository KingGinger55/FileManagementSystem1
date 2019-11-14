using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagementSystem
{
    public partial class LoginForm : Form
    {


        DatabaseConnection database = new DatabaseConnection();

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var RegisterScreen = new RegisterForm();
            RegisterScreen.Show();
            Console.Write("owo");
            Console.Write("uwu");

        




        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            String userName = userNameTextBox.Text;
            String password = passwordTextBox.Text;
            ArrayList userInfo = database.Login(userName, password);





            
            if (database.loginSuccess == true)
            {
                for (int i =0; i < userInfo.Count; i++)
                {
                    Console.WriteLine(userInfo[i]);
                }
                this.Close();
            }



            if (database.loginError == 1)
            {
                userNameTextBox.BackColor = Color.Salmon;
                passwordTextBox.BackColor = Color.Salmon;
            }

        }












        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            passwordTextBox.PasswordChar = '*';
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (database.loginSuccess == false)
            {
                Application.Exit();
            }
            
        }
    }
}
