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
			Console.Write("Enter the first number: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter the second number: ");
			double b = Convert.ToDouble(Console.ReadLine());

			double result = formula(a, b);

			Console.WriteLine($"Result: {result}");

		}
	}
}
