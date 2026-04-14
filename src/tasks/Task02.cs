using System;
using System.Collections.Generic;
using System.IO;

namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			string inputPath = "input2.txt";

			Queue<char> nonDigits = new Queue<char>();
			Queue<char> digits = new Queue<char>();

			// 1. One pass through the file
			using (StreamReader reader = new StreamReader(inputPath))
			{
				while (!reader.EndOfStream)
				{
					int ch = reader.Read();

					if (ch == -1) break;

					char c = (char)ch;

					if (char.IsDigit(c))
						digits.Enqueue(c);
					else
						nonDigits.Enqueue(c);
				}
			}

			// 2. Output
			Console.WriteLine("Result:");

			while (nonDigits.Count > 0)
				Console.Write(nonDigits.Dequeue());

			while (digits.Count > 0)
				Console.Write(digits.Dequeue());

			Console.WriteLine();
		}
	}
}