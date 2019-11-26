using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int Hits { get; set; }
        public char Type { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Length;
            }
        }
    }
}
