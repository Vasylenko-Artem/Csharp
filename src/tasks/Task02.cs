using System;
using System.IO;
using System.Text.RegularExpressions;

namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			string inputPath = "input.txt";
			string outputPath = "result.txt";

			string text = File.ReadAllText(inputPath);

			Console.WriteLine("Enter word to search:");
			string word = Console.ReadLine();

			// Search for whole word, case-insensitive
			string pattern = $@"\b{Regex.Escape(word)}\b";

			bool found = Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);

			string result = found
				? $"Word \"{word}\" found in the text."
				: $"Word \"{word}\" not found in the text.";

			// Output result
			Console.WriteLine(result);

			// Write to file
			File.WriteAllText(outputPath, result);
		}
	}
}