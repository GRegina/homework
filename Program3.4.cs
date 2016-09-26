using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int n, b, a, r, p, min1, min2, min3=10, s;
			n = int.Parse(Console.ReadLine());
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			r = a * b;
			min1 = r;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			r = a * b;
			if (r < min1)
			{
				p = min1;
				min1 = r;
				min2 = p;
			}
			else
			{
				min2 = r;
			}
			for (int i = 3; i <= n; i++)
			{
				a = int.Parse(Console.ReadLine());
				b = int.Parse(Console.ReadLine());
				p = a * b;
				if (p < min1)
				{
					min3 = min2;
					r = min1;
					min1 = p;
					min2 = r;
				}
				else
					if (p < min2)
				{
					r = min2;
					min2 = p;
					min3 = r;
				}
				else
						if (p < min3)
					min3 = p;  
			}
			s = min1 + min2 + min3;
			Console.WriteLine("сумма наимаеньших произведений = {0}", s);

		}
	}
}

