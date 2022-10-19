using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q7 根據不同時間return不同問安方式
			
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			if (hour >= 6 && hour < 11)
			{
				Console.WriteLine("Good morning!");
			} else if (hour >= 11 && hour < 17)
			{
				Console.WriteLine("Good afternoon!");
			}
			else
			{
				Console.WriteLine("Good evening!");
			}
		}
	}
}
