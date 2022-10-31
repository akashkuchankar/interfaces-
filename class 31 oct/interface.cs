//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace class_31_oct
//{
//    public class Player
//    {
//        private int runs;
//        private string name;
//        public Player(int runs, string name)
//        {
//            this.runs = runs;
//            this.name = name;
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
//        }

//    }
//}
