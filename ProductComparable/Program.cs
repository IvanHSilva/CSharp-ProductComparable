using ProductComparable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductComparable {
    internal class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV 4K", 1500.00));
            list.Add(new Product("Notebok", 1200.00));
            list.Add(new Product("Celular 128G", 2500.00));
            list.Add(new Product("Sound Bar", 600.00));
            list.Add(new Product("Pendrive 256G", 150.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.CompareTo(p2.Name);
            list.Sort(comp);

            foreach (Product p in list) {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
