using System;
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
            

           




        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            String userName = userNameTextBox.Text;
            String password = passwordTextBox.Text;



            DatabaseConnection database = new DatabaseConnection();
            database.Login(userName, password);
            if (database.loginSuccess == true)
            {
                this.Close();
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
    }
}
