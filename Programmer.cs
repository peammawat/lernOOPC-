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
        }

        public int Exp { get => exp; set => exp = value; }
    }
}
