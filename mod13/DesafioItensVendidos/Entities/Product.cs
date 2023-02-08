namespace DesafioItensVendidos.Entities {
    internal class Product {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public int Quantity { get; private set; }

        public Product() { }

            public Product(string productName, double price, int quantity) {
            Name = productName;
            Price = price;
            Quantity = quantity;
        }

        public double Total() {
            return Price * Quantity;
        }
    }
}
