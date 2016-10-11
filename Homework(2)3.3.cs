using System;

namespace Homeworknumber2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double a = 1, a1, b = 1 / Math.Sqrt(2), b1, t = 1 / 4, t1, p = 1, p1, n, pi = 1, e;
			e = double.Parse(Console.ReadLine());
			n = double.Parse(Console.ReadLine());
			while (pi > e)
			{
				for (int i = 0; i < n; i++)
				{
					pi = ((a + b) * (a + b)) / 4 * t;
					a1 = (a + b) / 2;
					b1 = Math.Sqrt(a * b);
					t1 = t - p * (a - a1) * (a - a1);
					p1 = 2 * p;
					a = a1;
					b = b1;
					t = t1;
					p = p1;
				}
			}
			Console.WriteLine("значение = {0}", pi);
		}
	}
}
