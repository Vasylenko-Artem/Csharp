// Завдання з масивами вирішити двома способами, 
// використовуючи одновимірний масив, а потім двовимірний. 
// Розмірність масиву вводиться з клавіатури. Задано масив. 
// Замінити всі елементи, менші заданого числа, цим числом.

namespace tasks
{
	public class Task01
	{
		private static void printArray(int[] arr)
		{
			foreach (int x in arr)
				Console.Write(x + " ");
		}

		private static void printArray(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
					Console.Write(arr[i, j] + " ");
				Console.WriteLine();
			}
		}

		private static void task_01()
		{
			Console.Write("Введіть розмір масиву: ");
			int n = int.Parse(Console.ReadLine());

			int[] arr = new int[n];

			Console.WriteLine("Введіть елементи масиву:");

			for (int i = 0; i < n; i++)
			{
				Console.Write($"arr[{i}] = ");
				arr[i] = int.Parse(Console.ReadLine());
			}

			Console.Write("Введіть число: ");
			int k = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				if (arr[i] < k)
					arr[i] = k;
			}

			Console.WriteLine("Результат:");

			printArray(arr);
		}

		private static void task_02()
		{
			Console.Write("Введіть кількість рядків: ");
			int rows = int.Parse(Console.ReadLine());

			Console.Write("Введіть кількість стовпців: ");
			int cols = int.Parse(Console.ReadLine());

			int[,] arr = new int[rows, cols];

			Console.WriteLine("Введіть елементи масиву:");

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"arr[{i},{j}] = ");
					arr[i, j] = int.Parse(Console.ReadLine());
				}
			}

			Console.Write("Введіть число: ");
			int k = int.Parse(Console.ReadLine());

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (arr[i, j] < k)
						arr[i, j] = k;
				}
			}

			Console.WriteLine("Результат:");

			printArray(arr);
		}

		public static void Run()
		{
			task_01();
			task_02();
		}
	}
}
