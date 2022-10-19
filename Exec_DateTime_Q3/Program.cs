using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q3 取得本月一日
			DateTime today = DateTime.Today;
			DateTime firstDay = today.AddDays(1-today.Day);
			Console.WriteLine(firstDay);
		}
	}
}
