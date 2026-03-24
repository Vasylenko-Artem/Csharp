using tasks;

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.WriteLine("Оберіть задачу для запуску (1-6) або 0 для виходу:");
			Console.WriteLine("1 — Task01");
			Console.WriteLine("2 — Task02");
			Console.WriteLine("2 — Task03");
			Console.WriteLine("2 — Task04");
			Console.Write("Ваш вибір: ");

			string input = Console.ReadLine();
			if (!int.TryParse(input, out int choice))
			{
				Console.WriteLine("Некоректне число. Спробуйте ще раз.\n");
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
				default:
					Console.WriteLine("Невірний вибір. Спробуйте ще раз.\n");
					break;
			}
			Console.ReadLine();
			Console.Clear();
		}
	}
}