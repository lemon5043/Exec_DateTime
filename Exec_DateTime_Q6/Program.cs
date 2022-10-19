using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q6 根據日期 return今天是本月的上旬、中旬還是下旬
			Console.Write("您想要查哪一個日期?");
			string input = Console.ReadLine();
			DateTime anyDate = Convert.ToDateTime(input);
			int day = anyDate.Day;
			int month = anyDate.Month;
			//算上中下勻不需要年份，因此這裡把年份去掉
			string dt = anyDate.ToString("MM月dd號");

			if (day <= 10)
			{
				Console.WriteLine($"{dt}位在{month}月的上旬");
			} else if (day > 10 && day <= 20)
			{
				Console.WriteLine($"{dt}位在{month}月的中旬");
			} else if (day > 20)
			{
				Console.WriteLine($"{dt}位在{month}月的下勻");
			}
		}
	}
}
