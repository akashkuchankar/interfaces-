//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace class_31_oct
//{
//    public class Player : IComparable
//    {
//        private int runs;
//        private string name;
//        public Player(int runs, string name)
//        {
//            this.runs = runs;
//            this.name = name;
//        }

//        public int CompareTo(object obj) // obj --> rohit details
//        {

//            type casting
//            Player p1 = (Player)obj;  // p1 --> rohit
//            if (this.runs > p1.runs)  // this  --> refer to current object (Virat)
//            {
//                return 1;
//            }
//            else if (this.runs < p1.runs)
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
//            return "Player :" + name + "  " + runs;
//        }
//    }

//    public class Team : IEnumerable
//    {
//        private Player[] players;
//        public Team()
//        {
//            players = new Player[3];
//            players[0] = new Player(12000, "Virat");
//            players[1] = new Player(13000, "Sachin");
//            players[2] = new Player(11000, "Dhoni");
//        }

//        public IEnumerator GetEnumerator()
//        {
//            return players.GetEnumerator();
//        }
//    }

//    public class Program
//    {

//        static void Main(string[] args)
//        {

//            Team team = new Team();
//            foreach (var item in team)
//            {
//                Console.WriteLine(item);
//            }

//            Player virat = new Player(13000, "Virat");
//            Player rohit = new Player(13000, "Rohit");

//            int result = virat.CompareTo(rohit);
//            if (result == 1)
//            {
//                Console.WriteLine("Virat have more runs than Rohit");
//            }
//            else if (result == -1)
//            {
//                Console.WriteLine("Rohit have more runs than Virat");
//            }
//            else
//            {
//                Console.WriteLine("Virat & Rohit have equal runs");
//            }
//        }


//    }

//}




