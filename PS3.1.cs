using System;
using System.Collections.Generic;

namespace LongAriphmetics
{
	class LongNumber
	{
		public List<int> number = new List<int>();
		private int sign = 1;

		public LongNumber(string a)
		{
			if (a.Contains("-"))
			{
				sign = -1;
				a = a.Substring(1);
			}
			else
			{
				sign = 1;
			}
			while (a.Length > 0)
			{
				number.Add(Convert.ToInt32(a.Substring(a.Length - 1)));
				a = a.Remove(a.Length - 1);
			}
		}
		public void WriteOut()
		{
			if (sign < 0)
			{
				Console.Write("-");
			}
			for (int i = number.Count - 1; i >= 0; i--)
			{
				Console.Write("{0}", number[i]);
			}
		}
		public LongNumber()
		{
		}
		public static LongNumber operator + (LongNumber x, LongNumber y)
		{
			int lenx = x.number.Count;
			int leny = y.number.Count;
			int p = 0, n;
			LongNumber o = new LongNumber();
			for (int i = 0; i < Math.Min(lenx, leny); i++)
			{
				n = p + x.number[i] + y.number[i];
				p = n / 10;
				o.number.Add(n % 10);
			}
			if (lenx > leny)
			{
				for (int i = leny; i < lenx; i++)
				{
					o.number.Add(p + x.number[i]);
					p = 0;
				}
			}
			else
			{
				for (int i = lenx; i < leny; i++)
				{
					o.number.Add(p + y.number[i]);
					p = 0;
				}
			}
			return o;
		}
		public static LongNumber operator * (LongNumber x, int y)
		{
			int lenx = x.number.Count;
			int n=0, p=0;
			LongNumber o = new LongNumber();
			int sign;
			if (y >= 0)
			{
				sign = 1;
			}
			else
			{
				sign = -1;
				y *= -1;
			}

			if (y / 10 == 0)
			{
				for (int i = 0; i < lenx; i++)
				{
					n = x.number[i] * y + p;
					p = n / 10;
					o.number.Add(n % 10);
				}
				if (p > 0)
				{
					o.number.Add(p);
				}
				o.sign = x.sign * sign;
			}
			else
			{
				string a = Convert.ToString(y);
				LongNumber y1 = new LongNumber(a);
				o = x * y1;
			}
			return o;	 
		}
		public static LongNumber operator * (LongNumber x, LongNumber y)
		{
			int lenx = x.number.Count;
			int leny = y.number.Count;
			LongNumber n = new LongNumber();
			LongNumber o = new LongNumber();
			for (int i = 0; i < lenx; i++)
			{
				n = y * x.number[i];
				for (int j = 0; j < i; j++)
				{
					n.number.Insert(0, 0);
				}
				o = o + n;
			}
			o.sign = x.sign * y.sign;
			return o;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int k;
			k = int.Parse(Console.ReadLine());
			LongNumber p = new LongNumber("1");
			LongNumber t = new LongNumber("0");
			for (int i = 1; i <= k; i++)
			{
				p = p * i;
				t = t + p * p;
			}
			t.WriteOut();
		}
	}
}
