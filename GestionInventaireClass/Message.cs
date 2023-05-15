using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionInventaireClass
{
    public class MessageDB
    {
        private string messageString;
        DateTime messageDate = new DateTime();


        public string MessageString { get { return messageString; } set { messageString = value; } }
        public DateTime MessageDate { get { return messageDate; } set { messageDate = value; } }
    }
}
