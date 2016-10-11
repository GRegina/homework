using System;

namespace Homeworknumber2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double e, s, n = 1, k = 1, d = 1, g, a;			
			e = double.Parse(Console.ReadLine());
			a = Math.Sqrt(3) + 2;		
			s = (n * n) / (2 * n) * (2 * n + 1) * (2 * n + 1);
			g = Math.PI / 8 * Math.Log(a) + 3 / 8 * s;		
			while (Math.Abs(s - g) > e)			
			{				
				n++;
				d = d * n;				
				k = k * 2 * n;			
				s = s + (d * d) / (k * (2 * n + 1) * (2 * n + 1));				
				g = Math.PI / 8 * Math.Log(a) + 3 / 8 * s;
			}
			Console.WriteLine("точность достигается на шаге {0}", n);
		}
	}
}
