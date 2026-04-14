using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace tasks
{
	public class Task01
	{
		public static void Run()
		{
			string inputPath = "input.txt";
			string outputPath = "output.txt";

			string text = File.ReadAllText(inputPath);

			// Regex for dates with range validation
			string pattern = @"\b(0?[1-9]|[12][0-9]|3[01])\.(0?[1-9]|1[0-2])\.(19\d{2}|20\d{2})\b";

			MatchCollection matches = Regex.Matches(text, pattern);

			List<string> dates = new List<string>();

			foreach (Match match in matches)
			{
				dates.Add(match.Value);
			}

			// Number of dates
			Console.WriteLine($"Found dates: {dates.Count}");

			// Write to file
			File.WriteAllLines(outputPath, dates);

			// Replace (example)
			Console.WriteLine("Enter date to replace:");
			string oldDate = Console.ReadLine();

			Console.WriteLine("Enter new date:");
			string newDate = Console.ReadLine();

			text = text.Replace(oldDate, newDate);

			// Delete (example)
			Console.WriteLine("Enter date to delete:");
			string deleteDate = Console.ReadLine();

			text = text.Replace(deleteDate, "");

			// Write modified text to new file
			File.WriteAllText("modified.txt", text);

			Console.WriteLine("Done!");
		}
	}
}