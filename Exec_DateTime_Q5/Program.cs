using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q5 列出指定年份的每一個星期日
			DateTime today = DateTime.Now;
			Console.Write("您想要查詢哪一年?(請輸入阿拉伯數字):");
			string input = Console.ReadLine();
			bool isInt = int.TryParse(input, out int year);

			if (!isInt)
			{
				Console.WriteLine("請輸入正確的日期");
				return;
			}

			DateTime thatYear = new DateTime(year, 1, 1);
			DateTime everySunday = thatYear;

			while (everySunday.DayOfWeek != DayOfWeek.Sunday)
			{
				everySunday = everySunday.AddDays(1);
			}

			while (year == everySunday.Year)
			{
				Console.WriteLine(everySunday.ToString("yyyy/MM/dd"));
				everySunday = everySunday.AddDays(7);
			}
		}

	}
}
