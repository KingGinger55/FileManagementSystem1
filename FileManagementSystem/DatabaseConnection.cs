using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DatabaseConnections
{

    public void CreateAdmin(String userName, String email, String fName, String lName, String password, String securityQuestion, String securityQuestionAnswer)
    {
        string query = "INSERT INTO `useraccount` (`uID`, `userName`, `email`, `fName`, `lName`, `password`, `accountType`, `securityQuestion`, `securityQuestionAnswer`) " +
            $"VALUES (NULL, '{userName}', '{email}', '{fName}', '{lName}', '{password}', 'admin', '{securityQuestion}', '{securityQuestionAnswer}')";


        Console.WriteLine(query);
        string mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password= ;database=filemanagementdatabase;";


        MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);

        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

        commandDatabase.CommandTimeout = 60;
       
        try
        {
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();



            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3));
                }
            }
            else
            {
                MessageBox.Show("Admin Creation Successful!");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            


            MessageBox.Show((String)e.Message);

        }
    }

}
