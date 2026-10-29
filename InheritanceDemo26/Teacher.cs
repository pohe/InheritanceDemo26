using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo26
{
    public class Teacher: Employee
    {
        public string Subject { get; set; }

        public Teacher(string name, string address, string subject):base(name,address)
        {
            Subject = subject; 
        }

        public override int CalculateSalary()
        {
            if (Subject == "Mathematics")
            {
                return 35000;
            }
            else
                //return base.CalculateSalary();
                return 32000; 
        }

    }
}
