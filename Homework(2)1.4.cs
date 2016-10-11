using System;

namespace Homework2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double e, s, k = 1, h = 1, x, d = 1, l = 1, i = 1;
			e = double.Parse(Console.ReadLine());
			x = double.Parse(Console.ReadLine());
			s = (h * x) / k;
			k = k + 1;
			l = l * x;
			while (Math.Abs(s - Math.Log(1 + x)) > e)
			{
				h = h * (-1);
				l = l * x;
				d = d * k;
				s = s + ((h * l) / d);
				k++;
                i++;
	        }
			Console.WriteLine(" точность достигается на шаге {0}", i);
		}
	}
}
