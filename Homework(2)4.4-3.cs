using System;

namespace Homeworknumber2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double a, b, h, s = 0, p, n, x, f1, f2, f3, f4, d = 2.56805;
			n = double.Parse(Console.ReadLine());
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			h = (b - a) / n;
			for (int i = 1; i <= n; i++)
			{
				x = a + i * h;
				f1 = -Math.Tan(1 / x + x);
				f2 = -Math.Tan(1 / x + 3 * h);
				f3 = -Math.Tan(1 / x + x + h);
				f4 = -Math.Tan(1 / x + x + 2 * h);
				s = s + ((f1-f2)/x + f3 + f4)
			}
			p = h * s;
			Console.WriteLine("значение интеграла = {0}", p);
			if (p < d)
			{
				Console.WriteLine("значение {0} меньше {1}", p,d);
			}
			else
			{
				Console.WriteLine("значение {0} больше {1}", p,d);
			}
					
			
		}
	}
}
