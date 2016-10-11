using System;

namespace Homeworknumber2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double a, b, h, s = 0, p, n, x, f, d = 0.804776;
			n = double.Parse(Console.ReadLine());
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			h = (b - a) / n;
			for (int i = 1; i <= n; i++)
			{
				x = a + i * h;
				f = Math.Sin(x * x);
				s = s + f;
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
