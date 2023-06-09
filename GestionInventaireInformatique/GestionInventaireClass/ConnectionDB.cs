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
using Org.BouncyCastle.Utilities.Collections;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;


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

                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "SELECT pseudo, password FROM administrators WHERE pseudo = @Pseudo && password = @password;";
                cmd.Parameters.AddWithValue("@pseudo", admin.Pseudo);
                cmd.Parameters.AddWithValue("@password", admin.Password);

                // Execute SQL command
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
                throw new Exception("Problème pour la connexion à la base de données!");
            }
            finally
            {
                //Close the datareader
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

                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "SELECT name FROM " + listName + ";";

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    list.Add(new string(rdr["name"].ToString()));
                }

                //Close the datareader
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


        /// <summary>
        /// This method is aimed to insert words to the lists
        /// </summary>
        public void InsertWord(string WordToAdd, string listName)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "INSERT INTO " + listName + " (name) VALUES(@WordToAdd);";
                cmd.Parameters.AddWithValue("@WordToAdd", WordToAdd);

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                //Close the datareader
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new Exception("Ce mot existe déjà dans la base de données!");
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }


        /// <summary>
        /// This method is aimed to delete word in the lists
        /// </summary>
        public void DeleteWord(string WordToDelete, string listName)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "DELETE FROM " + listName + " WHERE name=@WordToDelete;";
                cmd.Parameters.AddWithValue("@WordToDelete", WordToDelete);

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                //Close the connection
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new Exception("Cette element est lier à un objet, vous ne pouvez pas le supprimer!");
            }
            finally
            {
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }


        /// <summary>
        /// This method is aimed the id of a player from a pseudo
        /// </summary>
        public int GetId(string name, string ListName)
        {
            MySqlDataReader rdr = null;
            connection.Open();
            int id = -1;

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "SELECT id FROM " + ListName + " WHERE " + ListName + ".name = @name;";
                cmd.Parameters.AddWithValue("@name", name);

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id = Convert.ToInt32(rdr["id"]);
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
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return id;
        }

        /// <summary>
        /// This method is aimed to insert material in the DB
        /// </summary>
        public void InsertMaterial(material AddMaterial)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            ConnectionDB bdd = new ConnectionDB();
            int brands = bdd.GetId(AddMaterial.Brands, "brands");
            int stockagePlaces = bdd.GetId(AddMaterial.StockagePlaces, "storageplaces");
            int modules = bdd.GetId(AddMaterial.Modules, "modules");
            int types = bdd.GetId(AddMaterial.Types, "types");

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                //insert the material in the DB
                cmd.CommandText = "INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES (@name, @description, @dateOfPurchase," + brands + ", " + modules + ", " + stockagePlaces + ", @renewalDate, @quantity, " + types + ", " + 0 + ");";
                cmd.Parameters.AddWithValue("@name", AddMaterial.Name);
                cmd.Parameters.AddWithValue("@description", AddMaterial.Description);
                cmd.Parameters.AddWithValue("@dateOfPurchase", AddMaterial.PurchaseDate);
                cmd.Parameters.AddWithValue("@renewalDate", AddMaterial.RenewDate);
                cmd.Parameters.AddWithValue("@quantity", AddMaterial.Quantity);

                // Execute SQL command
                rdr = cmd.ExecuteReader();


                //Close the connection
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }


        /// <summary>
        /// This method is aimed the return a list of material
        /// </summary>
        public List<material> GetMaterials(bool trueOrFalse)
        {
            MySqlDataReader rdr = null;
            connection.Open();
            List<material> lstMaterial = new List<material>();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                if (trueOrFalse == false)
                {
                    // Request SQL
                    cmd.CommandText = "SELECT materials.name, `description`, `date of purchase`, brands.name, modules.name, storageplaces.name, `renewal DATE`, quantity, types.name, archived FROM materials LEFT JOIN brands ON materials.brand_id = brands.id LEFT JOIN modules ON materials.module_id = modules.id LEFT JOIN storageplaces ON materials.`storage place_id` = storageplaces.id LEFT JOIN types ON materials.type_id = types.id;";
                }
                else
                {
                    // Requête SQL for user so archived stuff is not taken
                    cmd.CommandText = "SELECT materials.name, `description`, `date of purchase`, brands.name, modules.name, storageplaces.name, `renewal DATE`, quantity, types.name, archived FROM materials LEFT JOIN brands ON materials.brand_id = brands.id LEFT JOIN modules ON materials.module_id = modules.id LEFT JOIN storageplaces ON materials.`storage place_id` = storageplaces.id LEFT JOIN types ON materials.type_id = types.id WHERE `archived` = 0;";
                }

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                //create a material with the DB data and add him on a list
                while (rdr.Read())
                {
                    material material = new material();
                    material.Name = rdr.GetString(0);
                    material.Description = rdr.GetString(1);
                    material.PurchaseDate = rdr.GetDateTime(2);
                    material.Brands = rdr.GetString(3);
                    material.Modules = rdr.GetString(4);
                    material.StockagePlaces = rdr.GetString(5);
                    material.RenewDate = rdr.GetDateTime(6);
                    material.Quantity = rdr.GetInt32(7);
                    material.Types = rdr.GetString(8);
                    material.Archived = rdr.GetBoolean(9);

                    lstMaterial.Add(material);
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
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return lstMaterial;
        }

        /// <summary>
        /// This method is aimed to update material in the DB
        /// </summary>
        public void UpdateMaterial(material AddMaterial, int id, string message)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            ConnectionDB bdd = new ConnectionDB();
            int brands = bdd.GetId(AddMaterial.Brands, "brands");
            int stockagePlaces = bdd.GetId(AddMaterial.StockagePlaces, "storageplaces");
            int modules = bdd.GetId(AddMaterial.Modules, "modules");
            int types = bdd.GetId(AddMaterial.Types, "types");

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                //insert the material in the DB
                cmd.CommandText = "UPDATE materials SET `name` = @name, `description`= @description, `date of purchase` = @dateOfPurchase, `brand_id` = " + brands + ", `module_id` = " + modules + ", `storage place_id` = " + stockagePlaces + ", `renewal DATE` = @renewalDate, quantity = @quantity, `type_id` = " + types + ", archived = @archived   WHERE materials.id = @id;";
                cmd.Parameters.AddWithValue("@name", AddMaterial.Name);
                cmd.Parameters.AddWithValue("@description", AddMaterial.Description);
                cmd.Parameters.AddWithValue("@dateOfPurchase", AddMaterial.PurchaseDate);
                cmd.Parameters.AddWithValue("@renewalDate", AddMaterial.RenewDate);
                cmd.Parameters.AddWithValue("@quantity", AddMaterial.Quantity);
                cmd.Parameters.AddWithValue("@archived", AddMaterial.Archived);
                cmd.Parameters.AddWithValue("@id", id);

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                //Close the connection
                connection.Close();
                //bdd.InsertMessage(message, id);
                bdd.InsertMessage(message, id);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new Exception("Le nom du matériel est déja existant dans la base de données!");
            }
            finally
            {
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }


        /// <summary>
        /// This method is aimed to insert words to the lists
        /// </summary>
        public void InsertMessage(string message, int idMaterial)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "INSERT INTO modifications (`modification`, `date`,`material_id`) VALUES(@message, @date, @id);";
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", idMaterial);

                // Execute SQL command
                rdr = cmd.ExecuteReader();


                //Close the connection
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new Exception("Ce message existe déjà dans la base de données!");
            }
            finally
            {
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        /// <summary>
        /// This method is aimed to return a list of message
        /// </summary>
        public List<MessageDB> GetMessages(string name)
        {
            MySqlDataReader rdr = null;
            List<MessageDB> listMessageReturn = new List<MessageDB>();
            connection.Open();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "SELECT `modification`, `date`, `name` FROM modifications LEFT JOIN materials ON modifications.material_id = materials.id WHERE `name` = @name;";
                cmd.Parameters.AddWithValue("@name", name);

                // Execute SQL command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MessageDB message = new MessageDB();
                    message.MessageString = rdr.GetString(0);
                    message.MessageDate = rdr.GetDateTime(1);

                    listMessageReturn.Add(message);
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
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return listMessageReturn;
        }



        /// <summary>
        /// This method is aimed to delete a specific object in the DB used in the test
        /// </summary>
        public void DeleteObject(string name)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "DELETE FROM materials WHERE `name` = @name;";
                cmd.Parameters.AddWithValue("@name", name);

                // Execute SQL command
                rdr = cmd.ExecuteReader();


                //Close the connection
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        /// <summary>
        /// This method is aimed to delete a specific message in the DB used in the test
        /// </summary>
        public void DeleteMessage(string message)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            try
            {
                //Create a SQL command with object connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Request SQL
                cmd.CommandText = "DELETE FROM modifications WHERE `modification` = @message;";
                cmd.Parameters.AddWithValue("@message", message);

                // Execute SQL command
                rdr = cmd.ExecuteReader();


                //Close the connection
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                //Close the datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }
    }
}
