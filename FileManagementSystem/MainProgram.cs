using System;
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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();
            MainMenuForm mainMenu = new MainMenuForm();







            Application.Run(login);
            mainMenu.getAccountInformation(login.pushUser());
            Application.Run(mainMenu);
            
        }
    }
}
