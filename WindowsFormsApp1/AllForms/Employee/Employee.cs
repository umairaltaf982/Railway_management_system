using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.AllForms.Employee
{
    public class Employee
    {
        public Employee() 
        {
            chairs = new List<int>();
        }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public List<int> chairs { get; set; }
        public double Price
        {
            get 
            {
                return chairs.Count * 10;
            }
        }
        public override string ToString()
        {
            return this.NameCustomer;
        }

    }
}
