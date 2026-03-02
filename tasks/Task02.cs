namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			Console.Write("Введіть перше число: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введіть друге число: ");
			double b = Convert.ToDouble(Console.ReadLine());

			double max = (a > b) ? a : b;

			Console.WriteLine($"Максимальне число: {max}");
		}
	}
}
