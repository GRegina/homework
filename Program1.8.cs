using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			double r1, r2, x1, x2, y1, y2, k;
			x1 = double.Parse(Console.ReadLine());
			y1 = double.Parse(Console.ReadLine());
			r1 = double.Parse(Console.ReadLine());
			x2 = double.Parse(Console.ReadLine());
			y2 = double.Parse(Console.ReadLine());
			r2 = double.Parse(Console.ReadLine());
			k = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
			if (k < (r1 + r2))
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}

