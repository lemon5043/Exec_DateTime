using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1 三天後DVD應歸還時間
			DateTime now = DateTime.Now;
			DateTime returnDVD = now.AddDays(3);
			Console.WriteLine($"借閱成功，請於{returnDVD:yyyy/MM/dd HH點mm分ss秒}前歸還DVD，感謝您的借閱!");
		}
	}
}
