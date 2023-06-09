using GestionInventaireClass;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using System.Xml.Linq;

namespace GestionInventaireTests
{
    public class Tests
    {
        public material materialExpected = new material();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAdminTest()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            Admin tritri = new Admin("admin", "Pa$$w0rd");
            bool resActual = false;
            //Act
            resActual = bdd.CheckAdmin(tritri);
            //Assert
            Assert.IsTrue(resActual);
        }

        [Test]
        public void CheckAdminFlaseTest()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            Admin tritri = new Admin("hello", "Pa$$w0rd");
            bool resActual = false;
            //Act
            resActual = bdd.CheckAdmin(tritri);
            //Assert
            Assert.IsFalse(resActual);
        }


        [Test]
        public void InsertDeleteWordGetListTest()
        {
            //Add and Delete are together to not leave stuff in the DB
            //Add Section 
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            List<string> listAddxpected = new List<string>();
            listAddxpected = bdd.GetList("storageplaces");
            listAddxpected.Add("SC-C444");
            List<string> listAdd = new List<string>();
            //Act
            bdd.InsertWord("SC-C444", "storageplaces");
            listAdd = bdd.GetList("storageplaces");
            //Assert
            Assert.AreEqual(listAddxpected, listAdd);


            //Delete Section
            //Arrange
            List<string> listDeleteExpected = new List<string>();
            listDeleteExpected = bdd.GetList("storageplaces");
            listDeleteExpected.Remove("SC-C444");
            List<string> listDelete = new List<string>();
            //Act
            bdd.DeleteWord("SC-C444", "storageplaces");
            listDelete = bdd.GetList("storageplaces");
            //Assert
            Assert.AreEqual(listDeleteExpected, listDelete);
        }

        [Test]
        public void GetIdTest()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            string storageplaces = "sc-C111";
            int idStoragePlaces = -1;
            int idExpected = 1;

            //Act
            idStoragePlaces = bdd.GetId(storageplaces, "storageplaces");
            //Assert
            Assert.AreEqual(idExpected, idStoragePlaces);
        }

        [Test]
        public void CheckMaterialInsertAndGetMaterial()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            List<material> listMaterialTest = new List<material>();
            material materialTest = new material();
            //set base data in the material
            materialExpected.Name = "PCTEST";
            materialExpected.Description = "PC de test";
            materialExpected.PurchaseDate = DateTime.Now.Date;
            materialExpected.Brands = "HP";
            materialExpected.Modules = "ICT-160";
            materialExpected.StockagePlaces = "sc-C236";
            materialExpected.RenewDate = DateTime.Now.Date;
            materialExpected.Quantity = 1;
            materialExpected.Types = "pc";
            materialExpected.Archived = false;

            //Act
            bdd.InsertMaterial(materialExpected);
            listMaterialTest = bdd.GetMaterials(false);
            //get the last created material
            materialTest = listMaterialTest.Last();
            //delete the material to let the DB clean
            bdd.DeleteObject("PCTEST");
            
            //Assert
            Assert.AreEqual(materialExpected.Name, materialTest.Name);
        }

        [Test]
        public void CheckMaterialUpdate()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            List<material> listMaterialTest = new List<material>();
            material materialTest = new material();
            //set base data in the material
            materialExpected.Name = "PCTEST";
            materialExpected.Description = "PC de test";
            materialExpected.PurchaseDate = DateTime.Now.Date;
            materialExpected.Brands = "HP";
            materialExpected.Modules = "ICT-160";
            materialExpected.StockagePlaces = "SC-C236";
            materialExpected.RenewDate = DateTime.Now.Date;
            materialExpected.Quantity = 1;
            materialExpected.Types = "pc";
            materialExpected.Archived = false;

            //Act
            bdd.InsertMaterial(materialExpected);
            int id = bdd.GetId(materialExpected.Name, "materials");
            //Update 
            materialExpected.Name = "PCTEST2";
            bdd.UpdateMaterial(materialExpected, id, "messgae Test Update");
            listMaterialTest = bdd.GetMaterials(false);
            //get the last created material
            materialTest = listMaterialTest.Last();
            //delete the material to let the DB clean
            bdd.DeleteMessage("messgae Test Update");
            bdd.DeleteObject("PCTEST2");

            //Assert
            Assert.AreEqual(materialExpected.Name, materialTest.Name);
        }

        [Test]
        public void InsertMessageAndGetMessage()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            List<MessageDB> ListMessage = new List<MessageDB>();
            MessageDB messageExpected = new MessageDB();
            //set base data in the message
            messageExpected.MessageDate = DateTime.Now;
            messageExpected.MessageString = "messgae Test2 Update";

            //create a material to be able to crate a messgae
            List<material> listMaterialTest = new List<material>();
            material materialTest = new material();
            //set base data in the material
            materialExpected.Name = "PCTEST";
            materialExpected.Description = "PC de test";
            materialExpected.PurchaseDate = DateTime.Now.Date;
            materialExpected.Brands = "HP";
            materialExpected.Modules = "ICT-160";
            materialExpected.StockagePlaces = "SC-C236";
            materialExpected.RenewDate = DateTime.Now.Date;
            materialExpected.Quantity = 1;
            materialExpected.Types = "pc";
            materialExpected.Archived = false;

            bdd.InsertMaterial(materialExpected);
            int id = bdd.GetId(materialExpected.Name, "materials");
            //Act
            //add a material to bind it on the message
            bdd.InsertMessage("messgae Test2 Update", id);
            //get the list of message and get the last one created
            ListMessage = bdd.GetMessages("PCTEST");
            MessageDB messageObtened = new MessageDB();
            messageObtened = ListMessage.Last();
            //delete test material/message to set the DB clean
            bdd.DeleteMessage("messgae Test2 Update");
            bdd.DeleteObject("PCTEST");
            //Assert
            Assert.AreEqual(messageExpected.MessageString, messageObtened.MessageString);
        }
    }
}