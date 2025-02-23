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
            Employee emp1 = new Employee();
            Employee emp2 = new Employee("peam",50000);

            /*emp2.showDetail();
             * 
            emp2.setName("peammawat");
            emp2.setSalary(100000);

            Console.WriteLine(emp2.getName());
            Console.WriteLine(emp2.getSalary());

            emp2.showDetail();*/

            /*Console.WriteLine(emp2.Name);
            Console.WriteLine(emp2.Salary);*/
            emp2.Name = "peammawat";
            emp2.Salary = 100000;
            Console.WriteLine(emp2.Name);
            Console.WriteLine(emp2.Salary);

            Console.ReadKey();
        }
    }
}
