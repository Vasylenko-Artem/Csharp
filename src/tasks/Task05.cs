using System;
using System.IO;

namespace tasks
{
	public class Task05
	{
		public static void Run()
		{
			string basePath = Path.Combine(Directory.GetCurrentDirectory(), "temp");
			string surname = "Vasylenko";

			string dir1 = Path.Combine(basePath, surname + "1");
			string dir2 = Path.Combine(basePath, surname + "2");

			// Creating folders
			Directory.CreateDirectory(dir1);
			Directory.CreateDirectory(dir2);

			// Creating files in folder 1
			string t1Path = Path.Combine(dir1, "t1.txt");
			string t2Path = Path.Combine(dir1, "t2.txt");

			string text1 = "Шевченко Степан Іванович, 2001 року народження, місце проживання м. Суми";
			string text2 = "Комар Сергій Федорович, 2000 року народження, місце проживання м. Київ";

			File.WriteAllText(t1Path, text1);
			File.WriteAllText(t2Path, text2);

			// Creating t3.txt (combining t1 + t2)
			string t3Path = Path.Combine(dir2, "t3.txt");

			string combinedText = File.ReadAllText(t1Path) + Environment.NewLine +
								  File.ReadAllText(t2Path);

			File.WriteAllText(t3Path, combinedText);

			// Information about files
			Console.WriteLine("Information about files:");
			PrintFileInfo(t1Path);
			PrintFileInfo(t2Path);
			PrintFileInfo(t3Path);

			// Moving t2.txt
			string newT2Path = Path.Combine(dir2, "t2.txt");
			File.Move(t2Path, newT2Path);

			// Copying t1.txt
			string copyT1Path = Path.Combine(dir2, "t1.txt");
			File.Copy(t1Path, copyT1Path, true);

			// Renaming folder + deletion
			string allDir = Path.Combine(basePath, "ALL");

			if (Directory.Exists(allDir))
				Directory.Delete(allDir, true);

			Directory.Move(dir2, allDir);
			Directory.Delete(dir1, true);

			// Information about files in ALL
			Console.WriteLine("\nFiles in folder ALL:");
			foreach (var file in Directory.GetFiles(allDir))
			{
				PrintFileInfo(file);
			}
		}

		static void PrintFileInfo(string path)
		{
			FileInfo info = new FileInfo(path);

			Console.WriteLine($"\nFile: {info.Name}");
			Console.WriteLine($"Path: {info.FullName}");
			Console.WriteLine($"Size: {info.Length} bytes");
			Console.WriteLine($"Created: {info.CreationTime}");
		}
	}
}