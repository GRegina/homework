using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int n, a, b, g;
			n = int.Parse(Console.ReadLine());
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			while (b != 0)
				b = a % (a = b);
			for (int i = 3; i <= n; i++)
			{
				g = int.Parse(Console.ReadLine());
				while (g != 0)
					g = a % (a = g);
			}
			Console.WriteLine("НОД наутральных чисел = {0}", a);

		}
	}
}
