using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lernOOPC_
{
    internal class Programmer : Employee
    {
        private int exp;

        public Programmer(string name, int salary, int exp):base(name,salary)
        {
            this.exp = exp;
            /*Console.WriteLine(name + " Working On " + base.officeName);*/
        }

        public int Exp { get => exp; set => exp = value; }

        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Exp = " + this.Exp);
            Console.WriteLine("-------------");
        }
    }
}
