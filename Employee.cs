using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lernOOPC_
{
    internal class Employee
    {

        private string name;
        private int salary;

        public Employee() {
            Console.WriteLine("Create object Employee Class");
        }

        public Employee(string nameValue, int salaryValue) {
            this.name = nameValue;
            this.salary = salaryValue;
        }

        /*public void showDetail() {
            Console.WriteLine("Name = " + this.name);
            Console.WriteLine("Salary = " + this.salary);
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public void setSalary(int newSalary)
        {
            this.salary = newSalary;
        }

        public string getName()
        {
            return this.name;
        }

        public int getSalary()
        {
            return this.salary;
        }*/
        
        /*public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }*/

        /*public string Name { get; set; }
        public int Salary { get; set; }*/

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
