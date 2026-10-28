using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo26
{
    public class Employee
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public string Address { get; set; }

        public Employee(string name, string address)
        {
            _name = name;
            Address = address; 
        }

        public virtual int CalculateSalary()
        {
            return 32000; 
        }
    }
}
