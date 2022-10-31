//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace class_31_oct
//{
//    internal class Product
//    {
//        private int price;
//        private string name;
//        public Product(int price, string name)
//        {
//            this.price = price;
//            this.name = name;
//        }
//        public override string ToString()
//        {
//            return "Product :" + price + "  " + name;
//        }
//    }

//    public class Equipment : IEnumerable
//    {
//        private Product[] p;
//        public Equipment()
//        {
//            p = new Product[3];
//            p[0] = new Product(234, "Vcd");
//            p[1] = new Product(133, "tv");
//            p[2] = new Product(11000, "DVD");
//        }

//        public IEnumerator GetEnumerator()
//        {
//            return p.GetEnumerator();
//        }
//    }

//    public class Program
//    {

//        static void Main(string[] args)
//        {

//            Equipment team = new Equipment();
//            foreach (var item in team)
//            {
//                Console.WriteLine(item);
//            }
//        }

//    }
//}
