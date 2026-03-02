namespace tasks
{
	public class Task01
	{
		public static void Run()
		{
			Console.Write("Enter the perimeter of the square: ");
			double a = Convert.ToDouble(Console.ReadLine());

			double side = a / 4;
			double area = side * side;

			Console.WriteLine($"Square area = {area}");
		}
	}
}
