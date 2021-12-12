using System;

namespace UpDownCasting.Models
{
    class M5 : BMW
    {
        public int SpeedCount { get; set; }
        public override void Drive()
        {
            Console.WriteLine("M5 is the fastest one");
        }
        public override void Speed()
        {
            Console.WriteLine("M5 can speed up to 250 km/h");
        }
    }
}
