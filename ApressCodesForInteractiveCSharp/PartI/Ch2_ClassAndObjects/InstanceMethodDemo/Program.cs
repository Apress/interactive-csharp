using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace InstanceMethodDemo
{
	class Ex5
	{
		public int sum(int x, int y)
		{
			return x + y;
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("*** A Simple class with a method returning an integer ***\n\n");
			Ex5 ob = new Ex5();
			int result = ob.sum(57,63);
			Console.WriteLine("Sum of 57 and 63 is : " + result);
			Console.ReadKey();

		}
	}
}
