namespace GestionInventaireClass
{
    public class material
    {
        private string name;
        private string description;
        DateTime purchaseDate = new DateTime();
        List<string> brands = new List<string>();
        List<string> modules = new List<string>();
        List<string> stockagePlaces = new List<string>();
        DateTime renewDate = new DateTime();
        private int quantity;
        List<string> types = new List<string>();
        private bool archived;



        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public DateTime PurchaseDate { get { return purchaseDate; } set { purchaseDate = value; } }
        public List<string> Brands { get { return brands; } set { brands = value; } }
        public List <string> Modules { get { return modules; } set { modules = value; } }
        public List<string> StockagePlaces { get { return stockagePlaces; } set { stockagePlaces = value; } }
        public DateTime RenewDate { get { return renewDate; } set { renewDate = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public List<string> Types { get { return types; } set { types = value; } }
        public bool Archived { get { return archived; } set { archived = value; } }
    }
}