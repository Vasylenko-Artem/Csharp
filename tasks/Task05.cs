namespace tasks
{
	public class Task05
	{
		static int Sum(int x, int y)
		{
			return x + y;
		}
		public static void Run()
		{
			Console.Write("Enter the first number: ");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the second number: ");
			int y = Convert.ToInt32(Console.ReadLine());

			int result = Sum(x, y);

			Console.WriteLine($"Сума чисел: {result}");

		}
	}
}
