using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q2 圖書館下個月歸還時間
			DateTime now = DateTime.Now;
			DateTime returnBook = now.AddMonths(1);
			Console.WriteLine($"借閱成功，請於{returnBook:yyyy/MM/dd HH點mm分ss秒}前還書，感謝您的借閱!");
		}
	}
}
