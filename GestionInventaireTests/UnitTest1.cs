using GestionInventaireClass;

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
            void ConnectionDB_CheckAdmin_Success()
            {
                //Arrange
                ConnectionDB bdd = new ConnectionDB();
                Admin tritri = new Admin("tristan", "Pa$$w0rd");
                bool redExpected = true;
                //Act
                bool resActual = bdd.CheckAdmin(tritri);
                //Assert
                Assert.AreEqual(redExpected, resActual);
            }
        }
    }
}