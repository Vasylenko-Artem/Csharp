using Vector;

namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			VectorInt v1 = new VectorInt(5, 2);
			VectorInt v2 = new VectorInt(5, 3);

			Console.WriteLine("v1:");
			v1.Print();

			Console.WriteLine("v2:");
			v2.Print();

			// Arithmetic
			var v3 = v1 + v2;
			Console.WriteLine("v1 + v2:");
			v3.Print();

			var v4 = v1 + 10;
			Console.WriteLine("v1 + 10:");
			v4.Print();

			// Bitwise
			var v5 = v1 | v2;
			Console.WriteLine("v1 | v2:");
			v5.Print();

			// Unary
			v1++;
			Console.WriteLine("v1++:");
			v1.Print();

			// Indexer
			Console.WriteLine($"v1[2] = {v1[2]}");
			Console.WriteLine($"v1[100] = {v1[100]}  (error={v1.CodeError})");

			// Comparison
			Console.WriteLine($"v1 == v2: {v1 == v2}");
			Console.WriteLine($"v1 > v2: {v1 > v2}");

			// true / false
			if (v1)
				Console.WriteLine("v1 is TRUE");
			else
				Console.WriteLine("v1 is FALSE");

			Console.WriteLine($"Vectors created: {VectorInt.CountVectors()}");
		}
	}
}