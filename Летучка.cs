using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letuchka
{
	public class Batch
	{
		public int Barcode { get; set; }
		public DateTime ReleaseDate { get; set; }

		//public List<Product> Product { get; set; } = new List<Product>();
		//public byte Quality { get; private set; }

		//public static byte Quality(Batch batch)
		//{
		//	int noDefective = 0;
		//	int intime = 0;
		//	int in5time = 0;

		//	for (int i = 0; i < batch.Product.Count; i++)
		//	{
		//		if (batch.Product[i].IsDefective != false)
		//			++noDefective;
		//		if (batch.Product[i].TimeSpent <= batch.Product[i].)
		//			++intime;
		//		if ((batch.Product[i].ReleaseDateTime > batch.Product[i].time) &&
		//			(batch.Product[i].ReleaseDateTime <= batch.Product[i].StandartTime + new TimeSpan(0, 5, 0)))
		//			++in5time;
		//	}

		//	byte DefectiveP = Convert.ToByte(noDefective / batch.Product.Count * 100);
		//	byte IntimeP = Convert.ToByte(intime / batch.Product.Count * 100);
		//	byte In5timeP = Convert.ToByte(in5time / batch.Product.Count * 100);

		//	if ((DefectiveP <= 3) && (IntimeP >= 80) && (intime + in5time == batch.Product.Count))
		//		return 1;

		//	if ((DefectiveP <= 5) && (IntimeP >= 75))
		//		return 2;
		//	else
		//		return 3;
		//}

		public override string ToString()
		{
			return string.Format($"Штрих-код:{Barcode} , Дата выпуска:{ReleaseDate} ");
		}
	}

	public class Product
	{
		public int Barcode { get; set; }
		public DateTime ReleaseDateTime { get; set; }
		public bool IsDefective { get; set; }
		public ProductDescription ProductDescription { get; set; }
		public WorkLogEntry WorkLogEntry { get; set; }
		//public List<WorkLogEntry> WorkLogEntries = new List<WorkLogEntry>();
		//public static byte Category (Product product)
		//{
		//	int noDefective = 0;
		//	int intime = 0;
		//	int in5time = 0;
		//	for (int i = 0; i < ; i++)
		//	{
		//		if (product.IsDefective != false)
		//			++noDefective;
		//		if (product.WorkLogEntry.TimeSpent <= product.ProductDescription.StandartTime)
		//			++intime;
		//		if ((product.WorkLogEntry.TimeSpent > product.ProductDescription.StandartTime) && (product.WorkLogEntry.TimeSpent <= product.ProductDescription.StandartTime + new TimeSpan(0, 5, 0)))
		//			++in5time;
		//	}
		//	byte DefectiveP = Convert.ToByte(noDefective / product.IsDefective * 100);
		//}
		//public TimeSpan TimeSpent
		//{
		//	get
		//	{
		//		TimeSpan time = new TimeSpan(0, 0, 0);
		//		for (int i = 0; i < WorkLogEntries.Count; i++)
		//			time += WorkLogEntries[i].TimeSpent;
		//		return time;
		//	}
		//}

		public override string ToString()
		{
			return string.Format($"Серийный номер:{Barcode} , Дата/время выпуска:{ReleaseDateTime} , Брак: {IsDefective} ");
		}
	}

	public class ProductDescription
	{
		public int Article { get; set; }
		public string Title { get; set; }
		public int StandartTime { get; set; }


		public override string ToString()
		{
			return string.Format($"Артикул:{Article} , Наименование:{Name} , Норма рабочего времени на изготовление:{StandartTime} ");
		}
	}
	public class WorkLogEntry
	{
		public DateTime DateTime { get; set; }
		public string Responsible { get; set; }
		public int TimeSpent { get; set; }
		public string Description { get; set; }

		public override string ToString()
		{
			return string.Format($" Дата и время внесения записи:{DateTime} , Рабочий, выполнявший работу:{Responsible} , Время работ:{TimeSpent} , Описание работ:{Description} ");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Batch t = new Batch();
			t.ReleaseDate = DateTime.Now;
			Console.WriteLine("Введите штрих-код");
			t.Barcode = int.Parse(Console.ReadLine());

			ProductDescription[] product = new ProductDescription[5];
			product[0] = new ProductDescription() { Article = 1111, Title = "Изделие 1", StandartTime = 1.25min };
			product[1] = new ProductDescription() { Article = 2222, Title = "Изделие 2", StandartTime = 2.33min };
			product[2] = new ProductDescription() { Article = 3333, Title = "Изделие 3", StandartTime = 4.40min };
			product[3] = new ProductDescription() { Article = 4444, Title = "Изделие 4", StandartTime = 3.17min };
			product[4] = new ProductDescription() { Article = 5555, Title = "Изделие 5", StandartTime = 5.00min};

			for (int i = 0; i < 5; i++)
				Console.WriteLine(product[i]);

			Product p = new Product();
			Console.WriteLine("Введите серийный номер");
			p.Barcode = int.Parse(Console.ReadLine());
			p.ReleaseDateTime = DateTime.Now;
			Console.WriteLine("Деффекты - true/false");
			p.IsDefective = bool.Parse(Console.ReadLine());
			Console.WriteLine("Выберите номенклатуру изделия");
			int u = int.Parse(Console.ReadLine());
			p.ProductDescription = product[u - 1];
			Console.WriteLine("Введите время, потраченное на изготовление");
			int time = int.Parse(Console.ReadLine());
			for (int i = 0; i < time; i++)
			{ 
				
			}
			}
		//сделала как смогла, запуталась там дальше

		}
 	}
}
