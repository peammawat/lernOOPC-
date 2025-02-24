using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lernOOPC_
{
    internal class Acc : Employee
    {
        private string gender;

        public Acc(string name,int salary,string gender):base(name,salary)
        {
            this.gender = gender;
            /*Console.WriteLine(name + " Working On " + base.officeName);*/
        }

        public string Gender { get => gender; set => gender = value; }

        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Gender = " + this.Gender);
            Console.WriteLine("-------------");
        }
    }
}
