using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo26
{
    public class IntTeacher : Teacher
    {
        public string Language { get; set; }

        public IntTeacher(string language, string name, string address, string subject): base(name,address, subject )
        {
            Language = language;
        }

        public override int CalculateSalary()
        {
            if (Language.ToLower() =="english")
            {
                return Convert.ToInt32( base.CalculateSalary()*1.5);
            }
            return base.CalculateSalary();
        }

    }
}
