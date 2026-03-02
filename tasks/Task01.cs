namespace tasks
{
	public class Task01
	{
		public static void Run()
		{
			Console.WriteLine("Запуск завдання 1.1");

			Console.Write("Введіть периметр квадрата: ");
			double a = Convert.ToDouble(Console.ReadLine());

			double side = a / 4;
			double area = side * side;

			Console.WriteLine($"Площа квадрата = {area}");
		}
	}
}
