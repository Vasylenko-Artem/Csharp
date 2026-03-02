namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			Console.Write("Enter the serial number of the month (1-12): ");
			int month = Convert.ToInt32(Console.ReadLine());

			if (month < 1 || month > 12)
			{
				Console.WriteLine("Incorrect month number!");
			}
			else
			{
				int remaining = 12 - month;
				Console.WriteLine($"To the end of the year left {remaining} months.");
			}
		}
	}
}
