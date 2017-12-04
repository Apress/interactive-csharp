using System;

namespace OptionalParameterEx1
{
    class Employee
    {
        public string Name;
        public int Id;
        public double Salary;
        public Employee(string name = "Anonymous", int id = 0, double salary = 0.01)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Optional Parameter Example-1***");

            Employee emp1 = new Employee("Amit", 1, 10000.23);
            Employee emp2 = new Employee("Sumit", 2);
            Employee emp3 = new Employee("Bob");
            Employee emp4 = new Employee();

            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name ={0} Id={1} Salary={2}", emp1.Name, emp1.Id, emp1.Salary);
            Console.WriteLine("Name ={0} Id={1} Salary={2}", emp2.Name, emp2.Id, emp2.Salary);
            Console.WriteLine("Name ={0} Id={1} Salary={2}", emp3.Name, emp3.Id, emp3.Salary);
            Console.WriteLine("Name ={0} Id={1} Salary={2}", emp4.Name, emp4.Id, emp4.Salary);
            Console.ReadKey();
        }
    }
}