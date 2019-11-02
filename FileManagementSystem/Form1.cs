﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace FileManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            runQuery();

        }

        private void runQuery()
        {
            string query = textBox1.Text;

            if (query == "")
            {
                MessageBox.Show("Please enter sql query!");
                return;
            }


            string mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password= ;database=testing;";


            MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();



                if (myReader.HasRows)
                {
                    MessageBox.Show("Your Query Generated Results");
                    while (myReader.Read())
                    {
                        Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("Query Successfully Executed");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Query Failed: " + e.Message);
            }
        }
    }
}