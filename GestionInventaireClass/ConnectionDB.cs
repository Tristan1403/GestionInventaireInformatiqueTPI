﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using System.Linq.Expressions;


namespace GestionInventaireClass
{
    public class ConnectionDB
    {
        public MySqlConnection connection;

        public ConnectionDB()
        {
            InitConnexion();
        }

        /// <summary>
        /// This method is aimed at initiating the MySQL connection
        /// </summary>
        public void InitConnexion()
        {
            // connection string creation : contact the DB server
            string connectionString = "SERVER=127.0.0.1; DATABASE=gestionInventaireInformatique; UID=AdminGestionInventaire; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);

        }

        /// <summary>
        /// This method is aimed to return true if the pseudo is found in the database
        /// </summary>
        public bool CheckAdmin(Admin admin)
        {
            bool test = false;
            MySqlDataReader rdr = null;

            try
            {
                connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT pseudo, password FROM administrators WHERE pseudo = @Pseudo && password = @password;";
                cmd.Parameters.AddWithValue("@pseudo", admin.Pseudo);
                cmd.Parameters.AddWithValue("@password", admin.Password);

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                //return true if pseudo and password are right
                while (rdr.Read())
                {
                    if (admin.Pseudo == rdr["pseudo"].ToString())
                    {
                        if (admin.Password == rdr["password"].ToString())
                        {
                            test = true;
                        }
                    }
                }

            }
            //catch connection error from mySQL then write them in GestionInventaire\GestionInventaireFront\bin\Debug\net6.0-windows\log.txt
            catch (Exception exc)
            {
                // Error management
                // We choose to create a log file with the exceptions we get
                Logger logger = new Logger();
                logger.writeInLogFile(Logger.Level.ERROR, Environment.CurrentDirectory, "log.txt", exc.Message);
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return test;
        }



        /// <summary>
        /// This method is aimed to return the list found in db
        /// </summary>

        public List<string> GetList(string listName)
        {
            connection.Open();

            MySqlDataReader rdr = null;
            List<string> list = new List<string>();

            try
            {

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                switch (listName)
                {
                    case "brands":
                        cmd.CommandText = "SELECT name FROM brands;";
                        break;
                    case "types":
                        cmd.CommandText = "SELECT name FROM types;";
                        break;
                    case "storageplaces":
                        cmd.CommandText = "SELECT name FROM storageplaces;";
                        break;
                    case "modules":
                        cmd.CommandText = "SELECT name FROM modules;";
                        break;
                    default:
                        break;
                }
              

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    list.Add(new string(rdr["name"].ToString()));
                }

                //Close the connection
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return list;
        }
    }
}