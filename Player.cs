using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Player //: Board
    {
        public string Name;
        public List<Ship> Ships;
        public Board PlayerBoard;
        public Player(string name)
        {
            Name = name;
            PlayerBoard = new Board();
            Ships = new List<Ship>()
            {
                new Battleship(),
                new Carrier(),
                new Cruiser(),
                new Submarine(),
                new Destroyer()
            };
             
        }

        public bool Lost()
        {
            return Ships.All(x => x.IsSunk);
        }

        public void PlaceShips(Ship ship)
        {
            int row = 0;
            int col = 0;
            char direction = 's';
            bool open = false;
            while(open == false)
            {
                Console.WriteLine("Enter row to start {0}(length={1}): ", ship.Name, ship.Length);
                row = Convert.ToInt32(Console.ReadLine()) - 1;
                
                Console.WriteLine("Enter column to start {0}(length={1}): ", ship.Name, ship.Length);
                col = Convert.ToInt32(Console.ReadLine()) - 1;
                if(row > 9 || col > 9 || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else if (Panel.IsTaken(PlayerBoard.Panels[row, col]))
                {
                    Console.WriteLine("Space is take, please try again");
                }
                else
                {
                    open = true;
                }
            }
            open = false;
            while(open == false)
            {
                Console.WriteLine("Choose direction (up=u, down=d, left=l, right=r restart=s): ");
                direction = Convert.ToChar(Console.ReadLine());
                switch (direction)
                {
                    default:
                        Console.WriteLine("Not valid direction");
                        break;
                    case 'u':
                      
                        for(int i=1;i<ship.Length;i++)
                        {
                            if(row-i < 1)
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else if(Panel.IsTaken(PlayerBoard.Panels[row - i, col]))
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }

                        break;
                    case 'd':
                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (row + i >= 10)
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row + i, col]))
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }

                        break;
                    case 'r':
                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (col + i >= 10)
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row, col+i]))
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }
                        
                        break;
                    case 'l':
                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (col - i < 1)
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row, col - i]))
                            {
                                Console.WriteLine("Not valid placement");
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }
                        
                        break;

                    case 's':
                        PlaceShips(ship);
                        return;
                }


            }
            switch (direction)
            {
                case 'u':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row - i, col].type = ship.Type;
                    }
                    break;
                case 'd':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row + i, col].type = ship.Type;
                    }
                    break;
                case 'l':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row, col - i].type = ship.Type;
                    }
                    break;
                case 'r':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row, col + i].type = ship.Type;
                    }
                    break;
            }
  
        }

        public void PlaceShips(Ship ship, string rand)
        {
            int row = 0;
            int col = 0;
            int direction = '0';
            bool open = false;
            Random random = new Random();
            row = random.Next(0,9);
            col = random.Next(0,9);
            if (Panel.IsTaken(PlayerBoard.Panels[row, col]))
            {
                row = random.Next(0, 9);
                col = random.Next(0, 9);
            }
            open = false;
            while (open == false)
            {
                direction = random.Next(1, 4);
                switch (direction)
                {
                    default:
                        direction = random.Next(1, 4);
                        Console.WriteLine(direction);
                        break;
                    case 1:

                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (row - i < 1)
                            {
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row - i, col]))
                            {
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }

                        break;
                    case 2:
                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (row + i >= 10)
                            {
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row + i, col]))
                            {
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }

                        break;
                    case 3:
                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (col + i >= 10)
                            {
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row, col + i]))
                            {
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }

                        break;
                    case 4:
                        for (int i = 1; i < ship.Length; i++)
                        {
                            if (col - i < 1)
                            {
                                open = false;
                                break;
                            }
                            else if (Panel.IsTaken(PlayerBoard.Panels[row, col - i]))
                            {
                                open = false;
                                break;
                            }
                            else
                            {
                                open = true;
                            }
                        }

                        break;

                }


            }
            switch (direction)
            {
                case 1:
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row - i, col].type = ship.Type;
                    }
                    break;
                case 2:
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row + i, col].type = ship.Type;
                    }
                    break;
                case 3:
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row, col + i].type = ship.Type;
                    }
                    break;
                case 4:
                    for (int i = 0; i < ship.Length; i++)
                    {
                        PlayerBoard.Panels[row, col - i].type = ship.Type;
                    }
                    break;
            }

            
        }
        public void Attack()
        {
            int row;
            int col;
            Console.WriteLine("Pick a row to attack: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a column to attack: ");
            col = Convert.ToInt32(Console.ReadLine());

        }
    }

}