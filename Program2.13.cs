using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int k, n, b, s = 0;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			while (n > 0)
			{
				b = n % k;
				s = s + b;
				b = n / k;
			}
			Console.WriteLine( "Summa = {0}", s);
		}
	}
}

