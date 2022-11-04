//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace class_31_oct
//{

//    public class Product : IComparable
//    {
//        private string name;
//        private int price;
//        public Product(string name, int price)
//        {

//            this.name = name;
//            this.price = price;
//        }

//        public int CompareTo(object obj) // obj --> rohit details
//        {

//            // type casting
//            Product p1 = (Product)obj;  // p1 --> rohit
//            if (this.price > p1.price)  // this  --> refer to current object (Virat)
//            {
//                return 1;
//            }
//            else if (this.price < p1.price)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;
//            }
//        }

//        public override string ToString()
//        {
//            return "Player :" + name + "  " + price;
//        }
//    }

//    public class Equipment : IEnumerable
//    {
//        private Product[] products;
//        public Equipment()
//        {
//            products = new Product[3];
//            products[0] = new Product("VCD", 346);
//            products[1] = new Product("LCD", 345);
//            products[2] = new Product("CD", 343);
//        }

//        public IEnumerator GetEnumerator()
//        {
//            return products.GetEnumerator();
//        }
//    }

//    public class Program
//    {

//        static void Main(string[] args)
//        {

//            Equipment items = new Equipment();
//            foreach (var item in items)
//            {
//                Console.WriteLine(item);
//            }

//            Product VCD = new Product("VCD", 346);
//            Product CD = new Product("CD", 343);

//            int result = VCD.CompareTo(CD);
//            if (result == 1)
//            {
//                Console.WriteLine("VCD has more price than CD");
//            }
//            else if (result == -1)
//            {
//                Console.WriteLine("CD has more price than VCD");
//            }
//            else
//            {
//                Console.WriteLine("VCD and CD have the same value");
//            }
//        }


//    }


//}
