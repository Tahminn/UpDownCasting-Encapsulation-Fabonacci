using System;
using UpDownCasting.Models;

namespace UpDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region UpCasting

            M5 m5 = new M5();

            Car m52 = m5;

            Car m53 = new M5();

            Car sclass = new Sclass();

            Car[] cars = { m5, m52, m53, sclass };

            foreach (var item in cars)
            {
                item.Speed();
            }


            #endregion

            #region DownCasting

            Car M5 = new M5();

            M5 M51 = (M5) M5;

            object[] objects = { 3, 5, "T", M5 };

            foreach (var item in objects)
            {
                if (item is M5)
                {
                    ((M5)item).Drive();
                }
                if (item is M5 x)
                {
                    x.Drive();
                }
                M5 M53 = item as M5;
                if (M5 != null)
                {
                    ((M5)item).Speed();
                }
                

            }

            #endregion

        }
    }
}
