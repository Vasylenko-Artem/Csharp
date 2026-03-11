// При вирішенні завдання використовувати одновимірний масив. 
// Розмірність масиву вводиться з клавіатури. 
// Дана послідовність з n дійсних чисел. 
// Вивести на екран номери всіх мінімальних елементів.

namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			Console.Write("Введіть кількість елементів n: ");
			int n = int.Parse(Console.ReadLine());

			double[] arr = new double[n];

			Console.WriteLine("Введіть елементи послідовності:");

			for (int i = 0; i < n; i++)
			{
				Console.Write($"a[{i}] = ");
				arr[i] = double.Parse(Console.ReadLine());
			}

			double min = arr[0];

			// пошук мінімального елемента
			for (int i = 1; i < n; i++)
			{
				if (arr[i] < min)
					min = arr[i];
			}

			Console.WriteLine($"Мінімальний елемент: {min}");
			Console.WriteLine("Номери мінімальних елементів:");

			for (int i = 0; i < n; i++)
			{
				if (arr[i] == min)
					Console.Write(i + " ");
			}
		}
	}
}
