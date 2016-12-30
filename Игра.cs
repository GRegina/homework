using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;


namespace tutorial1
{

	class Cursor
	{
		private int x;
		public int X
		{
			get
			{ return x; }
			set
			{ x = value; }

		}
		private int y;
		public int Y
		{
			get
			{ return y; }
			set
			{ y = value; }

		}
		public Cursor(int x, int y)
		{
			X = x;
			Y = y;
		}

		public void Play()
		{
			Console.SetCursorPosition(x, y);

		}

		public void Move(int dir)
		{
			if (dir == 1)
			{
				x -= 3;
				if (x < 0) x = 13;	
			}
			else if (dir == 2)
			{
				x += 3;
				if (x > 13) x = 1;
			}
			else if (dir == 3)
			{
				y--;
				if (y < 0) y = 4;
			}
			else if (dir == 4)
			{
				y++;
				if (y > 4) y = 0;
			}
			Play();
		}
	
	}



	class Program
	{

		public class pitch
		{
			string[,] battleground = new string[5, 5];

			public void up(string word)
			{
				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (i == 2)
						{
							battleground[i, j] = "[" + word[j] + "]";
							Console.ForegroundColor = ConsoleColor.DarkCyan;
							Console.Write(battleground[i, j]);
							Console.ResetColor();
						}

						else
						{
							battleground[i, j] = "[ ]";
							Console.Write(battleground[i, j]);
						}

					}
					Console.WriteLine();
				}
			}

			public void addSymbol(string symbol, int x, int y)
			{
				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (i == x && j == y)
						{
							battleground[i, j] = "[" + symbol + "]";
							Console.ForegroundColor = ConsoleColor.DarkMagenta;
							Console.Write(battleground[i, j]);
							Console.ResetColor();
						}
						else
						{
							battleground[i, j] = "[ ]";
							Console.Write(battleground[i, j]);
						}

					}
					Console.WriteLine();

				}
			}
			//public void first(string word) 
			//{ 

			// { 
			// for (int j = 0; j < 5; j++) 
			// { 
			// battleground[i, j] = "[ ]"; 
			// Console.Write(battleground[i, j]); 
			// } 
			// Console.WriteLine(); 
			// } 
			//} 
		}

		static void Main(string[] args)
		{ //начало игры 
			Boolean gameRunning = true;

			string name1 = Console.ReadLine();
			string name2 = Console.ReadLine();


			//задаем слово 
			Console.WriteLine("Введите первое слово из 5-ти букв:");
			string firstWord = Console.ReadLine();
			while (firstWord.Length != 5)
			{
				Console.WriteLine("Неправильное слово");
				firstWord = Console.ReadLine();
			}
			Console.Clear();

			pitch pole = new pitch();
			pole.up(firstWord);

			ConsoleKeyInfo key;

			Cursor cursor = new Cursor(7, 2);
			cursor.Play();

			while (true)
			{
				bool esc = false;
				int dir = 0;
				Thread.Sleep(10);

				if (Console.KeyAvailable)
				{

					key = Console.ReadKey();
					if (key.Key == ConsoleKey.LeftArrow)
						dir = 1;
					else if (key.Key == ConsoleKey.RightArrow)
						dir = 2;
					else if (key.Key == ConsoleKey.UpArrow)
						dir = 3;
					else if (key.Key == ConsoleKey.DownArrow)
						dir = 4;
					else if (key.Key == ConsoleKey.Escape)
						esc = true;
					else continue;
					if (esc)
						break;
					cursor.Move(dir);
					cursor.Play();
					pole.addSymbol(Console.ReadLine(), cursor.X, cursor.Y);
				}

			}

			//int count = 0; 
			//if (count % 2 == 0) 
			//{ 
			// Console.WriteLine("Ходит первый игрок."); 
			// count++; 
			//} 
			//else 
			//{ 
			// Console.WriteLine("ходит второй игрок"); 
			// count++; 
			//} 

			//конец 

			Console.WriteLine("игра окончена");
			Console.WriteLine("победил игрок");//+winnerName 
			Console.WriteLine("который набрал X очков");
		}
	}
}