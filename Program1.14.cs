using System;

namespace Programs
{
	class MainClass
	{
		public static void Main(string[] args)

		{
			int abcdef;
			abcdef = int.Parse(Console.ReadLine());
			int f = abcdef % 10;
			abcdef = abcdef / 10;
			int e = abcdef % 10; 
			abcdef = abcdef / 10;
			int d = abcdef % 10;
			abcdef = abcdef / 10;
			int c = abcdef % 10;
			abcdef = abcdef / 10;
			int b = abcdef % 10;
			abcdef = abcdef / 10;
			int a = abcdef % 10;
			if (a + b + c == d + e + f)
			{
				Console.WriteLine("Yes");
			}
			else 
			{
				Console.WriteLine("No");
			}


		}
	}
}

