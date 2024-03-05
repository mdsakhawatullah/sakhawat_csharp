using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class SpaceShip
    {
        public double Speed { get; set; }
        public abstract object CloneShip();

        public SpaceShip(double speed)
        {
            Speed = speed;
        }
    }
}
