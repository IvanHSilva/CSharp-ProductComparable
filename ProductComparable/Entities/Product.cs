using System;
using System.Globalization;

namespace ProductComparable.Entities {
    public class Product : IComparable<Product> {
        // Attributes
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructor
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // Methods
        public override string ToString() {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Product other) {
            return Name.CompareTo(other.Name);
        }
    }
}
