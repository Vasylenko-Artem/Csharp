using System.Collections.Generic;
using System.Linq;

namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			Console.WriteLine("STRUCT VERSION");
			StructVersion();

			Console.WriteLine("\nTUPLE VERSION");
			TupleVersion();

			Console.WriteLine("\nRECORD VERSION");
			RecordVersion();
		}

		// 1. STRUCT
		struct Abiturient
		{
			public string FullName;
			public int BirthYear;
			public int[] Exams;
			public double Avg;

			public void Print()
			{
				Console.WriteLine($"{FullName} | {BirthYear} | [{string.Join(",", Exams)}] | {Avg}");
			}
		}

		static void StructVersion()
		{
			List<Abiturient> list = new List<Abiturient>()
			{
				new Abiturient { FullName="Ivanov Ivan Ivanovich", BirthYear=2005, Exams=new[]{10,9,8}, Avg=9.0 },
				new Abiturient { FullName="Petrov Petr Petrovich", BirthYear=2004, Exams=new[]{8,7,9}, Avg=8.0 },
				new Abiturient { FullName="Sidorov Sidr", BirthYear=2006, Exams=new[]{12,11,10}, Avg=11.0 }
			};

			// Removal
			int indexToRemove = 1;
			if (indexToRemove >= 0 && indexToRemove < list.Count)
				list.RemoveAt(indexToRemove);

			// Addition
			string surname = "Ivanov";
			int pos = list.FindIndex(a => a.FullName.StartsWith(surname));
			if (pos != -1)
			{
				list.Insert(pos + 1, new Abiturient
				{
					FullName = "New Student",
					BirthYear = 2007,
					Exams = new[] { 7, 7, 7 },
					Avg = 7
				});
			}

			list.ForEach(a => a.Print());
		}

		// 2. TUPLE
		static void TupleVersion()
		{
			var list = new List<(string name, int year, int[] exams, double avg)>()
			{
				("Ivanov Ivan Ivanovich",2005,new[]{10,9,8},9),
				("Petrov Petr Petrovich",2004,new[]{8,7,9},8),
				("Sidorov Sidr",2006,new[]{12,11,10},11)
			};

			// Removal
			list.RemoveAt(1);

			// Addition
			int pos = list.FindIndex(a => a.name.StartsWith("Ivanov"));
			if (pos != -1)
				list.Insert(pos + 1, ("New Student", 2007, new[] { 6, 6, 6 }, 6));

			foreach (var a in list)
				Console.WriteLine($"{a.name} | {a.year} | [{string.Join(",", a.exams)}] | {a.avg}");
		}

		// 3. RECORD
		record AbiturientRecord(string Name, int Year, int[] Exams, double Avg);

		static void RecordVersion()
		{
			var list = new List<AbiturientRecord>()
			{
				new("Ivanov Ivan Ivanovich",2005,new[]{10,9,8},9),
				new("Petrov Petr Petrovich",2004,new[]{8,7,9},8),
				new("Sidorov Sidr",2006,new[]{12,11,10},11)
			};

			// Removal
			list.RemoveAt(1);

			// Addition
			int pos = list.FindIndex(a => a.Name.StartsWith("Ivanov"));
			if (pos != -1)
				list.Insert(pos + 1, new AbiturientRecord("New Student", 2007, new[] { 5, 5, 5 }, 5));

			foreach (var a in list)
				Console.WriteLine($"{a.Name} | {a.Year} | [{string.Join(",", a.Exams)}] | {a.Avg}");
		}
	}
}