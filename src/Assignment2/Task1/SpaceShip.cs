using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public  class SpaceShip<T, Q>
        where Q : SpaceShip<T, Q>, new()
    {
        public  T Speed { get; set; }

        public virtual Q CloneShip()
        {
       
            return new Q();
        }

        public SpaceShip()
        {
            
        }
    }
}
