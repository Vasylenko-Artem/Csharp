namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			Console.Write("Enter the first number: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter the second number: ");
			double b = Convert.ToDouble(Console.ReadLine());

			double max = (a > b) ? a : b;

			Console.WriteLine($"Maximum number: {max}");
		}
	}
}
