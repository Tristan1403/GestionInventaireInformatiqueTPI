namespace GestionInventaireClass
{
    public class material
    {
        private string name;
        private string description;
        DateTime purchaseDate = new DateTime();
        private string brands;
        private string modules;
        private string stockagePlaces;
        DateTime renewDate = new DateTime();
        private int quantity;
        private string types;
        private bool archived;


        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public DateTime PurchaseDate { get { return purchaseDate; } set { purchaseDate = value; } }
        public string Brands { get { return brands; } set { brands = value; } }
        public string Modules { get { return modules; } set { modules = value; } }
        public string StockagePlaces { get { return stockagePlaces; } set { stockagePlaces = value; } }
        public DateTime RenewDate { get { return renewDate; } set { renewDate = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Types { get { return types; } set { types = value; } }
        public bool Archived { get { return archived; } set { archived = value; } }
    }
}