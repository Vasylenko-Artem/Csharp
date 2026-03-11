// При вирішенні завдання використовувати двовимірний масив. 
// Дано масив розміром n×n, елементи якого цілі числа.
// Підрахувати середнє арифметичне парних елементів,
// розташованих нижче головної діагоналі.

namespace tasks
{
	public class Task03
	{
		public static void Run()
		{
			Console.Write("Введіть розмір матриці n: ");
			int n = int.Parse(Console.ReadLine());

			int[,] arr = new int[n, n];

			Console.WriteLine("Введіть елементи матриці:");

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write($"a[{i},{j}] = ");
					arr[i, j] = int.Parse(Console.ReadLine());
				}
			}

			int sum = 0;
			int count = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++) // нижче головної діагоналі
				{
					if (arr[i, j] % 2 == 0) // парне число
					{
						sum += arr[i, j];
						count++;
					}
				}
			}

			if (count > 0)
			{
				double average = (double)sum / count;
				Console.WriteLine("Середнє арифметичне парних елементів: " + average);
			}
			else
			{
				Console.WriteLine("Парних елементів нижче головної діагоналі немає.");
			}
		}
	}
}
