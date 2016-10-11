using System;

namespace Homework2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double e, s, k = 1, h = 1, x, d = 1, a, n, f = 1, c = 1, g = 1 ;
			e = double.Parse(Console.ReadLine());			
			x = double.Parse(Console.ReadLine());			
			a = double.Parse(Console.ReadLine());			
			n = double.Parse(Console.ReadLine());			
			f = x * x;		
			for (int i = 2; i < a; i++)			
			{				
				f = f * x;		
			}			
			s = ((-1 + a) * x * Math.Log(x) * Math.Log(x)) / n;			
			while (Math.Abs(s - f) > e)			
			{				
				while (k <= n)				
				{					
					h = h * (-1 + a);					
					k++;				
				}				
				d = d * g;
				g++;				
				s = s + (h * x * Math.Log(x) * Math.Log(x)) / d;				
				c++;			
				}
				Console.WriteLine("точность достигается на шаге {0}", c);
		}
	}
}
