using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int k, n, i, b, v = 1;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			i = n % k;
			while (n > 0)
			{
				b = i;
				n = n / k;
				i = n % k;
				if (b > i)
					v++;
				else
					v = 1;
			}

			Console.WriteLine("длина цепочки- {0}", v);

		}
	}
}

