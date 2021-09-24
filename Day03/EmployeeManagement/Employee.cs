using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{this.ID}\t{this.Name}\t{this.Email}\t{this.Salary}\t{this.Location}";
        }

    }
}
