using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public User userAccount;




        public MainMenuForm(String[] userData)
        {

            InitializeComponent();
            this.userAccount = new User(userData[0], userData[1], userData[2], userData[3], userData[4], userData[5]);
            Console.WriteLine(userAccount.userName);
            fileViewer.Url = new Uri($"C:/DSDB/{userAccount.userName}");

        }






        private void searchButton_Click(object sender, EventArgs e)
        {
            //var files = Directory.GetFiles("C:\\DSDB", textBox1.Text, SearchOption.TopDirectoryOnly);
            //For now we can search for specific file paths and it breaks if they are wrong
            //We want to use the top commented line, or some variation on it, to find all the files that may fit the search and show them
            fileViewer.Url = new Uri(textBox1.Text);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

            String currentDirectory = Directory.GetCurrentDirectory();

            //Gives the current working directory in the fileviewer
            Uri location = fileViewer.Url;
            Console.WriteLine(location);




        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            showCurrentUser();
        }

        public void initalizeFiles()
        {
            fileViewer.Url = new Uri("C:/DSDB");
        }



        public void showCurrentUser()
        {
            MessageBox.Show(userAccount.userName);
        }






        public void getAccountInformation(User userAccount)
        {
            this.userAccount = userAccount;
            MessageBox.Show("Main menu received user account!");
        }

        private void fileViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo($"C:/DSDB/{userAccount.userName}");
            DirectoryInfo[] folders = dir.GetDirectories();
            fileDropDown.Items.AddRange(folders);
            fileDropDown.Items.Add("Home Directory");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String changeDir = fileDropDown.Text;

            if (changeDir == "Home Directory")
            {
                fileViewer.Url = new Uri($"C:/DSDB/{userAccount.userName}");
            }
            else
            {
                fileViewer.Url = new Uri($"C:/DSDB/{userAccount.userName}/{changeDir}");
            }

            


        }
    }
    
}
