namespace tasks
{
	public class Task06
	{

		private static double formula(double a, double b)
		{
			return a + (a + b - 1) / (a * a + 1) - a * b;
		}

		public static void Run()
		{
			Console.Write("Введіть перше число: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введіть друге число: ");
			double b = Convert.ToDouble(Console.ReadLine());

			double result = formula(a, b);

			Console.WriteLine($"Сума чисел: {result}");

		}
	}
}
