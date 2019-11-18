using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagementSystem
{
    static class MainProgram
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            //DatabaseConnection.initialSetup();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            String[] userData = login.PushData();

            try
            {
                Application.Run(new MainMenuForm(userData));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }







        }
    }

}
