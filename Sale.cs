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
        }

        public string Area { get => area; set => area = value; }
    }
}
