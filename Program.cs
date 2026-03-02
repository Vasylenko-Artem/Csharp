using tasks;

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.WriteLine("Select a task to run (1-6) or 0 to exit:");
			Console.WriteLine("1 — Task01");
			Console.WriteLine("2 — Task02");
			Console.WriteLine("3 — Task03");
			Console.WriteLine("4 — Task04");
			Console.WriteLine("5 — Task05");
			Console.WriteLine("6 — Task06");
			Console.Write("Your choice: ");

			string input = Console.ReadLine();
			if (!int.TryParse(input, out int choice))
			{
				Console.Clear();
				Console.WriteLine("Invalid number. Try again.\n");
				Console.ReadLine();
				continue;
			}

			if (choice == 0) break;

			Console.Clear();

			switch (choice)
			{
				case 1: Task01.Run(); break;
				case 2: Task02.Run(); break;
				case 3: Task03.Run(); break;
				case 4: Task04.Run(); break;
				case 5: Task05.Run(); break;
				case 6: Task06.Run(); break;
				default:
					Console.WriteLine("Incorrect choice. Try again..\n");
					break;
			}
			Console.ReadLine();
			Console.Clear();
		}
	}
}