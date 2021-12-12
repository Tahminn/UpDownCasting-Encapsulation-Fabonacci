using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCasting.Models
{
    abstract class Car
    {
        public abstract void Drive();
        public virtual void Speed()
        {
            Console.WriteLine("The car can speed up to 300 km/h");
        }
    }
}
