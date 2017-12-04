using System;
using System.Collections.Generic;

namespace ReadingXMLFormatEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string employee =
              @"<EmpRecord>
                <Employee1>
                  <EmpName>Rohit</EmpName>
                  <EmpId>1001</EmpId>
                </Employee1>
                <Employee2>
                 <EmpName>Amit</EmpName>
                 <EmpId>1002</EmpId>
                </Employee2>
                <Employee3>
                 <EmpName></EmpName>
                 <EmpId>1003</EmpId>
                </Employee3>
                <Employee4>
                 <EmpName>Soham</EmpName>
                 <EmpId>1004</EmpId>
                </Employee4>
               </EmpRecord>";
            string[] splt = { "<EmpName>", "</EmpName>" };
            List<string> empNamesList = new List<string>();
            string[] temp = employee.Split(splt, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < temp.Length; i++)
            {
                if (!temp[i].Contains("<"))
                {
                    empNamesList.Add(temp[i]);
                }
            }
            Console.WriteLine("Employee names are as below:\n");
            foreach (string s in empNamesList)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
