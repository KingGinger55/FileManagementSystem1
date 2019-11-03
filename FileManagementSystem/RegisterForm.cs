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
        private int userNameError;
        private int fNameError;
        private int lNameError;
        private int emailError;
        private int passwordError;
        private int confirmPasswordError;
        private int securityQuestionError;
        private int securityAnswerError;
        //Database connection Class, for performin queries on the DB
        DatabaseConnection database = new DatabaseConnection();


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {

          
              

                //Creates an admin from the registration form, this will need to be modified so that all users arent admins (found in databaseConnection class)
                database.CreateAdmin(usernameTextBox.Text, emailTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, retypePassTextBox.Text, securityQuestionComboBox.Text, securityAnswerTextbox.Text);
                getRegisterErrors();

            if (userNameError == 1)
            {
                usernameTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
            if (fNameError == 1)
            {
                firstNameTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
            if (lNameError == 1)
            {
                lastNameTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
            if (emailError == 1)
            {
                emailTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
            if (passwordError == 1 || confirmPasswordError == 1)
            {
                passwordTextBox.BackColor = System.Drawing.Color.LightYellow;
                retypePassTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
            if (securityQuestionError == 1)
            {
                securityQuestionComboBox.BackColor = System.Drawing.Color.LightYellow;
            }
            if (securityAnswerError == 1)
            {
                securityAnswerTextbox.BackColor = System.Drawing.Color.LightYellow;
            }



        }

        private void retypePassTextBox_TextChanged(object sender, EventArgs e)
        {
         
            // The password character is an asterisk.
            retypePassTextBox.PasswordChar = '*';
        }



        private void getRegisterErrors()
        {
            userNameError = database.userNameError;
            fNameError = database.fNameError;
            lNameError = database.lNameError;
            emailError = database.emailError;
            passwordError = database.passwordError;
            confirmPasswordError = database.confirmPasswordError;
            securityQuestionError = database.securityQuestionError;
            securityAnswerError = database.securityAnswerError;
        }
    }

}

