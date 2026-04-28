using tasks;

class Program
{
	static void Main()
	{
		// while (true)
		// {
		// Console.WriteLine("Choose a task to run (1-6) or 0 to exit:");
		// Console.WriteLine("1 — Task01");
		// Console.Write("Your choice: ");

		// string input = Console.ReadLine();
		// if (!int.TryParse(input, out int choice))
		// {
		// 	Console.WriteLine("Invalid number. Try again.\n");
		// 	continue;
		// }

		// if (choice == 0) break;

		// Console.Clear();

		// switch (choice)
		// {
		// 	case 1: Task01.Run(); break;
		// 	default:
		// 		Console.WriteLine("Wrong choice. Try again.\n");
		// 		break;
		// }
		// Console.ReadLine();
		// Console.Clear();
		Task01.Run();
		// }
	}
}