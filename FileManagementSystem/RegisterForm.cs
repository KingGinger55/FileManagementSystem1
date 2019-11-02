using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {



            DatabaseConnections addAdmin = new DatabaseConnections();



        







            addAdmin.CreateAdmin(usernameTextBox.Text, emailTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, securityQuestionComboBox.Text, securityAnswerTextbox.Text);


           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void securityAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
