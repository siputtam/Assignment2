using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
	public abstract class Employee
	{
		int id;
		String emp_name;
		String desingnation;
		int emp_expr;
		int salary;
	DateTime date;
		public abstract int Calculate_Salary(int bsal, int expr);
	}

	public class HR : Employee
	{
		public override int Calculate_Salary(int bsal, int expr)
		{
			int salary = bsal + (1000 * expr);
			return salary;
		}
	}

	public class Developer : Employee
	{
		public override int Calculate_Salary(int bsal, int expr)
		{
			int salary = bsal + (2000 * expr);
			return salary;
		}
	}
}
