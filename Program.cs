using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lernOOPC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Employee emp1 = new Employee();
            Employee emp2 = new Employee("peam",50000);*/

            /*emp2.showDetail();
             * 
            emp2.setName("peammawat");
            emp2.setSalary(100000);

            Console.WriteLine(emp2.getName());
            Console.WriteLine(emp2.getSalary());

            emp2.showDetail();*/

            /*Console.WriteLine(emp2.Name);
            Console.WriteLine(emp2.Salary);*/
            /*emp2.Name = "peammawat";
            emp2.Salary = 100000;
            Console.WriteLine(emp2.Name);
            Console.WriteLine(emp2.Salary);*/

            /*Acc emp1 = new Acc();
            Sale emp2 = new Sale();*/
            /*Employee emp1 = new Acc();
            Employee emp2 = new Sale();
            emp1.Name = "peam";
            emp1.Salary = 80000;
            Console.WriteLine("Name = " + emp1.Name);
            Console.WriteLine("Salary = " + emp1.Salary);
            emp2.Name = "jostar";
            emp2.Salary = 180000;
            Console.WriteLine("Name = " + emp2.Name);
            Console.WriteLine("Salary = " + emp2.Salary);*/

            Employee emp1 = new Acc("bannawit",5000,"male");
            Employee emp2 = new Sale("kunakorn",35000,"bangna");
            Employee emp3 = new Programmer("peammawat",75000,5);
            emp1.showEmployee();
            emp2.showEmployee();
            emp3.showEmployee();
            Console.ReadKey();
        }
    }
}
