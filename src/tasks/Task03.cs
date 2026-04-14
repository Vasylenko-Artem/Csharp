using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace tasks
{
	public class MyItem : IComparable, ICloneable
	{
		public char Value { get; set; }

		public MyItem(char value)
		{
			Value = value;
		}

		public int CompareTo(object obj)
		{
			if (obj is MyItem other)
				return Value.CompareTo(other.Value);

			throw new ArgumentException("Invalid comparison");
		}

		public object Clone()
		{
			return new MyItem(this.Value);
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}

	public class MyCollection : IEnumerable
	{
		private ArrayList items = new ArrayList();

		public void Add(MyItem item)
		{
			items.Add(item);
		}

		public MyItem this[int index]
		{
			get { return (MyItem)items[index]; }
		}

		public int Count => items.Count;

		public IEnumerator GetEnumerator()
		{
			foreach (MyItem item in items)
				yield return item;
		}
	}

	public class Task01_ArrayList
	{
		public static void Run()
		{
			string input = "input.txt";
			string output = "output.txt";

			ArrayList list = new ArrayList();

			// Reading from file
			foreach (var line in File.ReadAllLines(input))
			{
				if (int.TryParse(line, out int num))
				{
					list.Add(num);
				}
			}

			// Reverse using ArrayList
			list.Reverse();

			// Writing to file
			using (StreamWriter writer = new StreamWriter(output))
			{
				foreach (int num in list)
				{
					writer.WriteLine(num);
				}
			}

			Console.WriteLine("Task01 done");
		}
	}

	public class Task02_ArrayList
	{
		public static void Run()
		{
			string input = "input2.txt";

			MyCollection nonDigits = new MyCollection();
			MyCollection digits = new MyCollection();

			using (StreamReader reader = new StreamReader(input))
			{
				while (!reader.EndOfStream)
				{
					char c = (char)reader.Read();

					MyItem item = new MyItem(c);

					if (char.IsDigit(c))
						digits.Add(item);
					else
						nonDigits.Add(item);
				}
			}

			// Output using IEnumerable
			Console.WriteLine("Result:");

			foreach (MyItem item in nonDigits)
				Console.Write(item);

			foreach (MyItem item in digits)
				Console.Write(item);

			Console.WriteLine();
		}
	}



	public class Task03
	{
		public static void Run()
		{
			Task01_ArrayList.Run();
			Task02_ArrayList.Run();
		}
	}
}