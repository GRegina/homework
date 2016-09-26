using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int k, n, i, r=0, l=0, t=0, g=0, h=0, max, f;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			while (n > 0)
			{
					i = n % k;

				switch (i)
				{
					case 0:
						r++;
						break;
					case 1:
						l++;
						break;
					case 2:
						t++;
						break;
					case 3:
						g++;
						break;
					case 4:
						h++;
						break;
				}
				n = n / k;
			}
			max = r;
			f = 0;
			if (l > max)
			{
				max = l;
				f = 1;
			}
			if (t > max)
			{
				max = t;
				f = 2;
			}
			if (g > max)
			{
				max = g;
				f = 3;
			}
			if (h > max)
			{
				max = h;
				f = 4;
			}
		
			Console.WriteLine("часто повторяющаяся цифра - {0}", f);

		}
	}
}

