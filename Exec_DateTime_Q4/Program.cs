using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q4 取得本月最後一天
			DateTime today = DateTime.Today;
			DateTime lastDay = today.AddMonths(1).AddDays(-today.Day);
			Console.WriteLine(lastDay);
		}
	}
}
