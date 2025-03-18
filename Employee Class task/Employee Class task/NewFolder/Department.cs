using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_task.NewFolder
{
    class Department
    {
        public string Name;
        public int EmployeeLimit;  //Employee=isci
        public Employee[] Employees;

        public Department(string name, int employeelimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;
        }
        public void AddEmployee(Employee employee, int i)
        {
            if (i <= EmployeeLimit)
            {
                Employees[i] = employee;

                Console.WriteLine("Employee arrayina elave edilecek");
            }
            else
            {
                Console.WriteLine("Employee arrayina elave edilmeyecek");
            }
        }
    }
}
     