﻿using System.Globalization;

namespace ExRemoveAll.Entities {
    internal class Product {

        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
