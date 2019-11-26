using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            //Board Board1 = new Board();
            //Board Board2 = new Board();
            //Board1.PrintBoard();
            //Board2.PrintBoard();
            Player Player1 = new Player("Player1");
            Player Computer = new Player("Computer");
            foreach (Ship x in Computer.Ships)
            {
                Computer.PlaceShips(x, "Computer");
                Computer.PlayerBoard.PrintBoard();
            }
            

        }
    }
}
