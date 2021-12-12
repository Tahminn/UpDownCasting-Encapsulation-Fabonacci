using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationGetSet.Models
{
    class Encapsulated
    {
        private string studentName;
        private int studentAge;

        public string Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }

    }
}
