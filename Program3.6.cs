using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int n, b, a, g = 1;
			n = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			for (int i = 2; i <= n; i++)
			{
				a = int.Parse(Console.ReadLine());
				if (a > b)
					b = a;
				else
				{
					g = 0;
					break;
				}

			}
			if (g == 0)
			{
				Console.WriteLine("не возрастающая");
			}
			else
			{
				Console.WriteLine("строго возрастающая");
			}

		}
	}
}

