using System;
namespace project
{
    public class Panel
    {
        public Coordinates Coordinates { get; set; }
        public char type;

        public Panel(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            type = 'o';
        }

        public string Status(char type)
        {
            switch (type)
            {
                case 'o':
                    return "Empty";
                    break;
                case 'B':
                    return "Battleship";
                    break;
                case 'C':
                    return "Cruiser";
                    break;
                case 'D':
                    return "Destroyer";
                    break;
                case 'S':
                    return "Submarine";
                    break;
                case 'A':
                    return "Carrier";
                    break;
                default:
                    return "Empty";
            }
        }

        public static bool IsTaken(Panel panel)
        {
              if (panel.Status(panel.type) == "Empty")
                {
                    return false;
                }
                else
                {
                    return true;
                }
                       
            
            
        }
    }
}

