using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_task.NewFolder
{
    class Employee
    {
        public string Name;
        public double Salary;

        public Employee (string name,double salary)
        {
            Name = name;
            Salary = salary;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name},{Salary}");
        }
    }
}
