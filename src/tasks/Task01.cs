using System;
using System.Collections.Generic;
using System.IO;

namespace tasks
{
	public class Task01
	{
		public static void Run()
		{
			string inputPath = "input.txt";
			string outputPath = "output.txt";

			Stack<int> stack = new Stack<int>();

			// 1. Read numbers from file and push to stack
			using (StreamReader reader = new StreamReader(inputPath))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();

					if (int.TryParse(line, out int number))
					{
						stack.Push(number);
					}
				}
			}

			// 2. Pop elements from the stack (in reverse order)
			using (StreamWriter writer = new StreamWriter(outputPath))
			{
				while (stack.Count > 0)
				{
					writer.WriteLine(stack.Pop());
				}
			}

			Console.WriteLine("Done!");
		}
	}
}