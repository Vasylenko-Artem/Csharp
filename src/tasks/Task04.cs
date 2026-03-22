using Matrix;

namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			MatrixInt m1 = new MatrixInt(2, 2, 2);
			MatrixInt m2 = new MatrixInt(2, 2, 3);

			Console.WriteLine("m1:");
			m1.Print();

			Console.WriteLine("m2:");
			m2.Print();

			var sum = m1 + m2;
			Console.WriteLine("m1 + m2:");
			sum.Print();

			var mul = m1 * m2;
			Console.WriteLine("m1 * m2:");
			mul.Print();

			var scalar = m1 + 5;
			Console.WriteLine("m1 + 5:");
			scalar.Print();

			m1++;
			Console.WriteLine("m1++:");
			m1.Print();

			Console.WriteLine($"m1 == m2: {m1 == m2}");
			Console.WriteLine($"m1 > m2: {m1 > m2}");

			Console.WriteLine($"m1[0,1] = {m1[0, 1]}");
			Console.WriteLine($"m1[5] = {m1[5]} (error={m1.CodeError})");

			if (m1)
				Console.WriteLine("m1 TRUE");

			Console.WriteLine($"Matrices created: {MatrixInt.Count()}");
		}
	}
}