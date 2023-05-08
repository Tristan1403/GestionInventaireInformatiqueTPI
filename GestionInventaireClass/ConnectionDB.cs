using MySql.Data.MySqlClient;
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
                throw new Exception("Problème pour la connexion à la base de données!");
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
                cmd.CommandText = "SELECT name FROM " + listName + ";";


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


        /// <summary>
        /// This method is aimed to insert words to the lists
        /// </summary>
        public void InsertWord(string WordToAdd, string listName)
        {
            MySqlDataReader rdr = null;
            connection.Open();

            try
            {

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL

                cmd.CommandText = "INSERT INTO " + listName + " (name) VALUES(@WordToAdd);";
                cmd.Parameters.AddWithValue("@WordToAdd", WordToAdd);

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();


                //Close the connection
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

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL

                cmd.CommandText = "DELETE FROM " + listName + " WHERE name=@WordToDelete;";
                cmd.Parameters.AddWithValue("@WordToDelete", WordToDelete);

                // Exécution de la commande SQL
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
                //Fermeture du datareader
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

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT id FROM " + ListName + " WHERE " + ListName + ".name = @name;";
                cmd.Parameters.AddWithValue("@name", name);

                // Exécution de la commande SQL
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
                //Fermeture du datareader
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

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL

                cmd.CommandText = "INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES (@name, @description, @dateOfPurchase," + brands + ", " + modules + ", " + stockagePlaces + ", @renewalDate, @quantity, " + types + ", " + 0 + ");";
                cmd.Parameters.AddWithValue("@name", AddMaterial.Name);
                cmd.Parameters.AddWithValue("@description", AddMaterial.Description);
                cmd.Parameters.AddWithValue("@dateOfPurchase", AddMaterial.PurchaseDate);
                cmd.Parameters.AddWithValue("@renewalDate", AddMaterial.RenewDate);
                cmd.Parameters.AddWithValue("@quantity", AddMaterial.Quantity);

                // Exécution de la commande SQL
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
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }
    }
}
