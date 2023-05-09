using GestionInventaireClass;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace GestionInventaireTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAdminTest()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            Admin tritri = new Admin("tristan", "Pa$$w0rd");
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
        public void GetListTest()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            List<string> listexpected = new List<string>();
            listexpected.Add("SC-C111");
            listexpected.Add("SC-C236");
            List<string> list = new List<string>();
            //Act
            list = bdd.GetList("storageplaces");
            //Assert
            Assert.AreEqual(listexpected, list);
        }

        [Test]
        public void InsertDeleteWordTest()
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
            string storageplaces = "SC-C111";
            int idStoragePlaces = -1;
            int idExpected = 2;

            //Act
            idStoragePlaces = bdd.GetId(storageplaces, "storageplaces");
            //Assert
            Assert.AreEqual(idExpected, idStoragePlaces);
        }

        [Test]
        public void InsertMaterialTest()
        {
            //Arrange
            ConnectionDB bdd = new ConnectionDB();
            string storageplaces = "SC-C111";
            int idStoragePlaces = -1;
            int idExpected = -50;

            //Act
            idStoragePlaces = bdd.GetId(storageplaces, "storageplaces");
            //Assert
            Assert.AreEqual(idExpected, idStoragePlaces);
        }
    }
}