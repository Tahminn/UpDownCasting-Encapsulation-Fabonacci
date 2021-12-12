using System;

namespace UpDownCasting.Models
{
    class Sclass : Mercedes
    {
        public int LuxuryRate { get; set; }
        public override void Drive()
        {
            Console.WriteLine("Sclass is the luxury one");
        }
        public override void Speed()
        {
            Console.WriteLine("Sclass can speed up to 200 km/h");
        }
    }
}
