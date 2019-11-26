using System;
using System.Collections.Generic;
namespace project
{
    public class Board //: Panel
    {
        public Panel [,] Panels = new Panel[10,10];
        public Board()
        {

            for (int k = 0; k<10; k++)
            {
                for (int i = 0; i<10; i++)
                {
                    Panels[k,i] = new Panel(k, i);
                }
            }
	    }

        public void PrintBoard()
        {
            for (int row = 0; row<10; row++)
            {
                for (int col = 0; col<10; col++)
                {
                    Console.Write("{0} ",Panels[row,col].type);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

