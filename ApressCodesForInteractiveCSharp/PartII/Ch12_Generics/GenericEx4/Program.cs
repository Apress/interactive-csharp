using System;

namespace GenericEx4
{
    interface ISameEmployee<T>
    {
        string CheckForIdenticalEmployee(T obj);
    }
    class Employee : ISameEmployee<Employee>
    {
        string deptName;
        int employeeID;
        public Employee(string deptName, int employeeId)
        {
            this.deptName = deptName;
            this.employeeID = employeeId;
        }
        public string CheckForIdenticalEmployee(Employee obj)
        {
            if (obj == null)
            {
                return "Cannot Compare with a Null Object";
            }
            else
            {
                if (this.deptName == obj.deptName && this.employeeID == obj.employeeID)
                {
                    return "Same Employee";
                }
                else
                {
                    return "Different Employee";
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Suppose, we have an  Employee class that contains deptName and employeeID***");
            Console.WriteLine("***We need to check whether 2 employee objects are same or not.***");
            Console.WriteLine();
            Employee emp1 = new Employee("Maths", 1);
            Employee emp2 = new Employee("Maths", 2);
            Employee emp3 = new Employee("Comp. Sc.", 1);
            Employee emp4 = new Employee("Maths", 2);
            Employee emp5=null;
            Console.WriteLine("Comparing Emp1 and Emp3 :{0}", emp1.CheckForIdenticalEmployee(emp3));
            Console.WriteLine("Comparing Emp2 and Emp4 :{0}", emp2.CheckForIdenticalEmployee(emp4));
            Console.WriteLine("Comparing Emp3 and Emp5 :{0}", emp3.CheckForIdenticalEmployee(emp5));
            Console.ReadKey();
        }
    }

}
