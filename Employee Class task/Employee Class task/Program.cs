
using Employee_Class_task.NewFolder;

namespace Employee_Class_task
{
     class Program
    {
        static void Main()
        {
            Department department = new Department("IT", 3);
            Employee employee1 = new Employee("Ayaz", 7896);
            Employee employee2 = new Employee("Ahu", 8790);
            Employee employee3 = new Employee("Nur", 9876);
            employee1.ShowInfo();
            employee2.ShowInfo();
            employee3.ShowInfo();
            




        }
    }
}

