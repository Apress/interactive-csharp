using System;
using System.Collections.Generic;

namespace GenericConstraintEx
{
    interface IEmployee
    {
        string Position();
    }
    class Employee : IEmployee
    {
        public string Name;
        public int yearOfExp;
        public Employee(string name, int years)
        {
            this.Name = name;
            this.yearOfExp = years;
        }
        public string Position()
        {
            if (yearOfExp < 5)
            {
                return " A Junior Employee";
            }
            else
            {
                return " A Senior Employee";
            }
        }

    }
    //class EmployeeStoreHouse<Employee> where Employee : IEmployee
    ////class EmployeeStoreHouse<Employee>//error
    //{
    //    private List<Employee> MyStore = new List<Employee>();
    //    public void AddToStore(Employee element)
    //    {
    //        MyStore.Add(element);
    //    }
    //    public void DisplaySore()
    //    {
    //        Console.WriteLine("The store contains:");
    //        foreach (Employee e in MyStore)
    //        {
    //            Console.WriteLine(e.Position());
    //        }
    //    }
    //}
    //More general form
    class EmployeeStoreHouse<T> where T : IEmployee
    {
        private List<T> MyStore = new List<T>();
        public void AddToStore(T element)
        {
            MyStore.Add(element);
        }
        public void DisplaySore()
        {
            foreach (T e in MyStore)
            {
                Console.WriteLine(e.Position());
            }
        }
    }


    namespace Generic.Constraint_1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("***Example of Generic Constraints***");
                //Employees
                Employee e1 = new Employee("Amit", 2);
                Employee e2 = new Employee("Bob", 5);
                Employee e3 = new Employee("Jon", 7);

                //Employee StoreHouse
                EmployeeStoreHouse<Employee> myEmployeeStore = new EmployeeStoreHouse<Employee>();
                myEmployeeStore.AddToStore(e1);
                myEmployeeStore.AddToStore(e2);
                myEmployeeStore.AddToStore(e3);

                //Display the Employee Positions in Store
                myEmployeeStore.DisplaySore();
                Console.ReadKey();
            }
        }
    }

}
