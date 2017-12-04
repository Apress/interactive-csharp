using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace IndexerQuiz1
{
    class EmployeeRecord
    {
        Dictionary<string, double> employeeWithSalary;
        public EmployeeRecord()
        {
            employeeWithSalary = new Dictionary<string, double>();
            employeeWithSalary.Add("Amit",20125.87);
            employeeWithSalary.Add("Sam",56785.21);
            employeeWithSalary.Add("Rohit",33785.21);
        }
        public bool this[string index, int predictedSalary]
        {
            get
            {
                double salary = 0.0;
                bool foundEmployee = false;
                bool prediction = false;
                foreach (string s in employeeWithSalary.Keys)
                {
                    
                    if (s.Equals(index))
                    {
                        foundEmployee = true;//Employee found
                        salary = employeeWithSalary[s];//Employees actual salary                     
                        if( salary>predictedSalary)
                        {
                            //Some code
                            prediction = true;
                        }
                        else
                        {
                            //Some code
                        }
                     break;
                    }                    
                }
                if(foundEmployee == false)
                {
                  Console.WriteLine("Employee {0} Not found in our database.", index);
                }
                return prediction;
            }
        }
    }

    class Program
    {
       static void Main(string[] args)
       {
         Console.WriteLine("***Quiz on Indexers***\n");
            EmployeeRecord employeeSalary = new EmployeeRecord();
            Console.WriteLine("Is Rohit's salary is more than 25000$ ?- {0}", employeeSalary["Rohit",25000]);//True
            Console.WriteLine("Is Amit's salary is more than 25000$ ?- {0}", employeeSalary["Amit",25000]);//False
            Console.WriteLine("Is Jason's salary is more than 10000$ ?-{0}", employeeSalary["Jason",10000]);//False
            Console.ReadKey();
       }
    }
}
