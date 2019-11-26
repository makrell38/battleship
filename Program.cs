using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        //public Board Board1 { get; set; }
        static void Main(string[] args)
        {
            Board Board1 = new Board();
            Board Board2 = new Board();
            Board1.PrintBoard();
            Board2.PrintBoard();
        }
    }
}
