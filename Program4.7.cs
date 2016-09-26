using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int k, n=0, i=0, t=0;
			k = int.Parse(Console.ReadLine());
			while (t==0)
			{
				i++;

				for (int v = 1; v <= k; v++)
				{
					if (i % v == 0)
						n = 1;
					else
					{
						n = 0;
						break;
					}
				}
				if (n == 1)
					t = 1;
			}
			Console.WriteLine("наименьший целый делитель = {0}", i);

		} 
	}
}
