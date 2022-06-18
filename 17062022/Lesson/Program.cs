using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 45;

            int num1 = (int)obj;

            Console.WriteLine(num1);
            
            int num = 45;

            byte n = (byte)num;

            Human human = new Human()
            {
                FullName = "Abbas Hikmetov"
            };

            Employee employee = new Employee
            {
                FullName = "Nermin Quluzade",
                Position = "Developer"
            };

            //employee = (Employee)human;
            employee = human as Employee;

            if(employee is null)
                Console.WriteLine("Employee nuldir");
            else
                Console.WriteLine(employee.FullName);

            Human[] humans = new Human[]
            {
                new Student
                {
                    FullName = "A",
                    GroupNo = "B"
                },
                new Employee
                {
                    FullName = "AA",
                    Salary = 500
                },
                new Employee
                {
                    FullName = "AA",
                    Salary = 2500
                },
                new Employee
                {
                    FullName = "AA",
                    Salary = 350
                },
                 new Student
                {
                    FullName = "A",
                    GroupNo = "B"
                },
            };

            double sum = 0;
            foreach (var item in humans)
            {
                
                if(item is Employee) 
                {
                    Employee emp = (Employee)item;
                    sum += emp.Salary;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
