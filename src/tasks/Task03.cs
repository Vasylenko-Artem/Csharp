using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace tasks
{
	public class Task03
	{
		public static void Run()
		{
			string inputPath = "input.txt";
			string outputPath = "result.txt";

			string text = File.ReadAllText(inputPath);

			// Word with double letters (case-insensitive)
			string pattern = @"\b\w*([a-zA-Zа-яА-ЯіїєІЇЄ])\1\w*\b";

			MatchCollection matches = Regex.Matches(text, pattern);

			List<string> removedWords = new List<string>();

			foreach (Match match in matches)
			{
				removedWords.Add(match.Value);
			}

			// Remove these words from the text
			string cleanedText = Regex.Replace(text, pattern, "").Trim();

			// Remove extra spaces
			cleanedText = Regex.Replace(cleanedText, @"\s+", " ");

			// Form the line of removed words
			string removedLine = string.Join(" ", removedWords);

			// Output
			Console.WriteLine("Removed words:");
			Console.WriteLine(removedLine);

			Console.WriteLine("\nText after removal:");
			Console.WriteLine(cleanedText);

			// Write to file
			using (StreamWriter writer = new StreamWriter(outputPath))
			{
				writer.WriteLine("Removed words:");
				writer.WriteLine(removedLine);
				writer.WriteLine();
				writer.WriteLine("Text after removal:");
				writer.WriteLine(cleanedText);
			}
		}
	}
}