using System;
using System.Collections.Generic;
using System.Text;
//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace SynCoolFeedback
{
    class DBconn
    {

        //private MySqlConnection conn;
        private string server;
        private string database;
        private string username;
        private string password;


        public DBconn()
        {
            //ApriConnessione();
        }

        private async void ApriConnessione()
        {

            //var builder = new MySqlConnectionStringBuilder
            //{
            //    Server = "localhost",
            //    UserID = "username",
            //    Password = "",
            //    Database = "syncoolprova",
            //};

            //using (var con = new MySqlConnection(builder.ConnectionString))
            //{
            //    Console.WriteLine("Opening connection");
            //    await con.OpenAsync();
            //}
            //server = "localhost";
            //database = "syncoolprova";
            //username = "root";
            //password = "";
            //string connectionString;
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            //database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            //conn = new MySqlConnection(connectionString);
        }
        //open connection to database

        //private bool ApriConnessione()
        //{
        //    Inizializza();



        //    try
        //    {
        //        conn.Open();
        //        return true;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        //When handling errors, you can your application's response based 
        //        //on the error number.
        //        //The two most common error numbers when connecting are as follows:
        //        //0: Cannot connect to server.
        //        //1045: Invalid user name and/or password.
        //        switch (ex.Number)
        //        {
        //            case 0:
        //                //MessageBox.Show("Cannot connect to server.  Contact administrator");
        //                break;

        //            case 1045:  //errore username o password sbagliati
        //                //MessageBox.Show("Invalid username/password, please try again");
        //                break;
        //        }
        //        return false;
        //    }

        //}

        //Close connection
        //    private bool ChiudiConnessione()
        //    {
        //        try
        //        {
        //            conn.Close();
        //            return true;
        //        }
        //        catch (MySqlException ex)
        //        {
        //            //MessageBox.Show(ex.Message);
        //            return false;
        //        }
        //    }

        //    //Insert statement
        //    public async void Inserisci(string query, MySqlConnection con)
        //    {

        //        using (var command = con.CreateCommand())
        //        {
        //            command.CommandText = query;
        //            await command.ExecuteNonQueryAsync();
        //            Console.WriteLine("Caricamento completato");

        //        }
        //            ////open connection
        //            //if (this.ApriConnessione() == true)
        //            //{
        //            //    //create command and assign the query and connection from the constructor
        //            //    MySqlCommand cmd = new MySqlCommand(query, conn);

        //            //    //Execute command
        //            //    cmd.ExecuteNonQuery();

        //            //    //close connection
        //            //    this.ChiudiConnessione();
        //            //}
        //    }

        //    //Update statement
        //    public async void Aggiorna(string query, MySqlConnection con)
        //    {
        //        using (var command = con.CreateCommand())
        //        {
        //            command.CommandText = query;
        //            int rowCount = await command.ExecuteNonQueryAsync();
        //            Console.WriteLine(String.Format("Number of rows updated={0}", rowCount));
        //        }

        //        //Open connection
        //        //if (this.ApriConnessione() == true)
        //        //{
        //        //    //create mysql command
        //        //    MySqlCommand cmd = new MySqlCommand();
        //        //    //Assign the query using CommandText
        //        //    cmd.CommandText = query;
        //        //    //Assign the connection using Connection
        //        //    cmd.Connection = conn;

        //        //    //Execute query
        //        //    cmd.ExecuteNonQuery();

        //        //    //close connection
        //        //    this.ChiudiConnessione();
        //        //}
        //    }

        //    //Delete statement
        //    public async void Cancella(string query, MySqlConnection con)
        //    {
        //        using (var command = con.CreateCommand())
        //        {
        //            command.CommandText = query;

        //            int rowCount = await command.ExecuteNonQueryAsync();
        //            Console.WriteLine(String.Format("Number of rows deleted={0}", rowCount));
        //        }


        //        //if (this.ApriConnessione() == true)
        //        //{
        //        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //        //    cmd.ExecuteNonQuery();
        //        //    this.ChiudiConnessione();
        //        //}
        //    }
    }
}
