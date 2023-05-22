using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventaireClass
{
    public class Admin
    {
        private string pseudo;
        private string password;

        public Admin(string pseudo, string password)
        {
            this.pseudo = pseudo;   
            this.password = password;
        }

        public string Pseudo { get { return pseudo; } }
        public string Password { get { return password; } }
    }
}
