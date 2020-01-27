using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee E1;
			E1 = new HR();
			Console.WriteLine(" Enter HR's Basic Salary : ");
			int bsal = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Enter HR's Year of Experience : ");
			int h_expr = Convert.ToInt32(Console.ReadLine());
			int sal_hr = E1.Calculate_Salary(bsal, h_expr);

			E1 = new Developer();
			Console.WriteLine(" Enter Developer's Basic Salary : ");
			int d_bsal = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Enter Developer's Year of Experience : ");
			int d_expr = Convert.ToInt32(Console.ReadLine());
			int sal_dev = E1.Calculate_Salary(d_bsal, d_expr);

			Console.WriteLine("The Salary of HR is : " + sal_hr);
			Console.WriteLine("The Salary of Developer is : " + sal_dev);
		}
	}

}
