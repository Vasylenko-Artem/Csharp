namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			Console.Write("Введіть порядковий номер місяця (1-12): ");
			int month = Convert.ToInt32(Console.ReadLine());

			if (month < 1 || month > 12)
			{
				Console.WriteLine("Некоректний номер місяця!");
			}
			else
			{
				int remaining = 12 - month;
				Console.WriteLine($"До кінця року залишилося {remaining} місяців.");
			}
		}
	}
}
