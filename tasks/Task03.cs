namespace tasks
{
	public class Task03
	{
		public static void Run()
		{
			Console.Write("Введіть координату x: ");
			double x = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введіть координату y: ");
			double y = Convert.ToDouble(Console.ReadLine());

			double R = 12.0;
			double distSquared = x * x + y * y;

			if (Math.Abs(distSquared - R * R) < 1e-6 || Math.Abs(y - x) < 1e-6)
			{
				Console.WriteLine("На межі");
			}
			else if (distSquared < R * R && y < x)
			{
				Console.WriteLine("Так");
			}
			else
			{
				Console.WriteLine("Ні");
			}

		}
	}
}
