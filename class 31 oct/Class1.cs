//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace class_31_oct
//{
//    public class MyGeneric<T>
//    {
//        private T data;
//        public string value;
//        public void Accept(T data)
//        {
//            this.data = data;
//        }

//        public T GetData()
//        {
//            return data;
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            MyGeneric<int> myGeneric1 = new MyGeneric<int>();
//            myGeneric1.Accept(10);

//            // MyGeneric<Employee> myGeneric2 = new MyGeneric<Employee>();
//            // myGeneric2.Accept(new Employee("test", 20000));

//            MyGeneric<string> s = new MyGeneric<string>();
//            s.Accept("Hello");


//        }


//    }

//}

