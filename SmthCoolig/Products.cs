namespace SmthCoolig
{
    public class Products
    {
        private string _name = " ";
        private int _quantity = 0;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _name = value;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative");
                }
            }
        }

        public Products(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
        public void Restock(int amount, Products product)
        {
            if (product.Quantity < 100)
            {
                throw new ArgumentException("Cannot restock a product that is already full");
            }
            else
            {
                product.Quantity += amount;
            }
        }

        public override string ToString()
        {
            return $"Product: {Name}, Quantity: {Quantity}";
        }
    }
}
