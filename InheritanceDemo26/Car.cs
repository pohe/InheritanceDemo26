using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo26
{
    public class Car
    {
        public string RegNo { get; set; }

        public Car(string regNo)
        {
            RegNo = regNo;
        }

 

        public override string ToString()
        {
            return $"Regno {RegNo}";
        }
    }
}
