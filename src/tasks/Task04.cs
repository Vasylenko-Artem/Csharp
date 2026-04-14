using System;
using System.IO;

namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			string path = "numbers.bin";

			int count = 10; // How many degrees to write

			// Write to binary file
			using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				for (int i = 0; i < count; i++)
				{
					int value = (int)Math.Pow(3, i);
					writer.Write(value);
				}
			}

			// Reading from file
			using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				int index = 0;

				Console.WriteLine("Elements with even sequential numbers:");

				while (reader.BaseStream.Position < reader.BaseStream.Length)
				{
					int value = reader.ReadInt32();

					// Even sequential numbers (2nd, 4th...) => index % 2 == 0
					if (index % 2 == 0)
					{
						Console.WriteLine(value);
					}

					index++;
				}
			}
		}
	}
}