using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo26
{
    public class Secretary :Employee
    {
        public int TypingSpeed { get; set; }

        public Secretary(string name, string address, int typingSpeed): base(name, address)
        {
            TypingSpeed = typingSpeed;
        }
        public override int CalculateSalary()
        {
            return base.CalculateSalary() * 2;
        }
    }

    
}
