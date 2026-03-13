// Варіанти задач. Дано східчастий масив з n рядків,
// у рядках по mj (j=1..n) елементів. Знайти мінімальний елемент 
// в кожному стовпці і записати дані в новий масив.

namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			Console.Write("Введіть кількість рядків n: ");
			int n = int.Parse(Console.ReadLine());

			int[][] arr = new int[n][];

			// введення східчастого масиву
			for (int i = 0; i < n; i++)
			{
				Console.Write($"Кількість елементів у рядку {i}: ");
				int m = int.Parse(Console.ReadLine());

				arr[i] = new int[m];

				for (int j = 0; j < m; j++)
				{
					Console.Write($"a[{i}][{j}] = ");
					arr[i][j] = int.Parse(Console.ReadLine());
				}
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + " ");
				}
				Console.WriteLine();
			}

			// знаходимо максимальну кількість стовпців
			int maxCols = 0;
			for (int i = 0; i < n; i++)
				if (arr[i].Length > maxCols)
					maxCols = arr[i].Length;

			int[] result = new int[maxCols];

			// пошук мінімуму в кожному стовпці
			for (int j = 0; j < maxCols; j++)
			{
				bool found = false;
				int min = 0;

				for (int i = 0; i < n; i++)
				{
					if (j < arr[i].Length)
					{
						if (!found)
						{
							min = arr[i][j];
							found = true;
						}
						else if (arr[i][j] < min)
						{
							min = arr[i][j];
						}
					}
				}

				result[j] = min;
			}

			Console.WriteLine("Мінімальні елементи кожного стовпця:");

			for (int i = 0; i < result.Length; i++)
				Console.Write(result[i] + " ");

		}
	}
}
