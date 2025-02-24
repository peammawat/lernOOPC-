using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lernOOPC_
{
    internal class Sale : Employee
    {
        private string area;

        public Sale(string name, int salary, string area) : base(name, salary)
        {
            this.area = area;
            /*Console.WriteLine(name + " Working On " + base.officeName);*/
        }

        public string Area { get => area; set => area = value; }

        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Area = " + this.Area);
            Console.WriteLine("-------------");
        }
    }
}
