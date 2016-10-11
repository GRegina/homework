using System;

namespace Homeworknumber2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double e, s, n = 1, k = 1, d = 1, a = 1;			
			e = double.Parse(Console.ReadLine());			
			s = (2 * k * (k * (2 * k - k))) / (2 * k);		
			k = k + 1;			
			while (Math.Abs(-2 + 2 * s - Math.PI)>e)			
			{				
				d = d * k;				
				n = n * 2 * k;				
				a = a * (2 * k - k);				
				s = s + (2 * k * d * a) / n;				
			}
			Console.WriteLine("точность достигается на шаге {0}", n);
		}
	}
}
