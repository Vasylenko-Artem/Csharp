namespace Matrix
{
	public class MatrixInt
	{
		protected int[,] IntArray;
		protected int n, m;
		protected int codeError;
		protected static int num_vec = 0;

		// Constructor
		public MatrixInt()
		{
			n = m = 1;
			IntArray = new int[1, 1];
			num_vec++;
		}

		public MatrixInt(int n, int m)
		{
			this.n = n;
			this.m = m;
			IntArray = new int[n, m];
			num_vec++;
		}

		public MatrixInt(int n, int m, int value)
		{
			this.n = n;
			this.m = m;
			IntArray = new int[n, m];

			for (int i = 0; i < n; i++)
				for (int j = 0; j < m; j++)
					IntArray[i, j] = value;

			num_vec++;
		}

		// Destructor
		~MatrixInt()
		{
			Console.WriteLine("Matrix destroyed");
		}

		// Methods
		public void Print()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
					Console.Write(IntArray[i, j] + " ");
				Console.WriteLine();
			}
		}

		public void SetAll(int value)
		{
			for (int i = 0; i < n; i++)
				for (int j = 0; j < m; j++)
					IntArray[i, j] = value;
		}

		public static int Count() => num_vec;

		// Properties
		public int Rows => n;
		public int Cols => m;

		public int CodeError
		{
			get => codeError;
			set => codeError = value;
		}

		// Indexer
		public int this[int i, int j]
		{
			get
			{
				if (i >= 0 && i < n && j >= 0 && j < m)
					return IntArray[i, j];

				codeError = -1;
				return 0;
			}
			set
			{
				if (i >= 0 && i < n && j >= 0 && j < m)
					IntArray[i, j] = value;
				else
					codeError = -1;
			}
		}

		public int this[int k]
		{
			get
			{
				int i = k / m;
				int j = k % m;

				if (i < n)
					return IntArray[i, j];

				codeError = -1;
				return 0;
			}
			set
			{
				int i = k / m;
				int j = k % m;

				if (i < n)
					IntArray[i, j] = value;
				else
					codeError = -1;
			}
		}

		// Unary
		public static MatrixInt operator ++(MatrixInt a)
		{
			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < a.m; j++)
					a.IntArray[i, j]++;
			return a;
		}

		public static MatrixInt operator --(MatrixInt a)
		{
			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < a.m; j++)
					a.IntArray[i, j]--;
			return a;
		}

		public static bool operator true(MatrixInt a)
		{
			if (a.n == 0 || a.m == 0) return false;

			foreach (var x in a.IntArray)
				if (x == 0) return false;

			return true;
		}

		public static bool operator false(MatrixInt a) => !(a);

		public static bool operator !(MatrixInt a)
		{
			return a.n != 0 && a.m != 0;
		}

		public static MatrixInt operator ~(MatrixInt a)
		{
			var res = new MatrixInt(a.n, a.m);
			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < a.m; j++)
					res[i, j] = ~a[i, j];
			return res;
		}

		// General logic
		private static MatrixInt Apply(MatrixInt a, MatrixInt b, Func<int, int, int> op)
		{
			if (a.n != b.n || a.m != b.m)
				return a; // по условию

			var res = new MatrixInt(a.n, a.m);

			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < a.m; j++)
					res[i, j] = op(a[i, j], b[i, j]);

			return res;
		}

		private static MatrixInt Apply(MatrixInt a, int s, Func<int, int, int> op)
		{
			var res = new MatrixInt(a.n, a.m);

			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < a.m; j++)
					res[i, j] = op(a[i, j], s);

			return res;
		}

		// Arithmetic
		public static MatrixInt operator +(MatrixInt a, MatrixInt b) => Apply(a, b, (x, y) => x + y);
		public static MatrixInt operator +(MatrixInt a, int s) => Apply(a, s, (x, y) => x + y);

		public static MatrixInt operator -(MatrixInt a, MatrixInt b) => Apply(a, b, (x, y) => x - y);
		public static MatrixInt operator -(MatrixInt a, int s) => Apply(a, s, (x, y) => x - y);

		public static MatrixInt operator *(MatrixInt a, int s) => Apply(a, s, (x, y) => x * y);

		// Multiplication matrix
		public static MatrixInt operator *(MatrixInt a, MatrixInt b)
		{
			if (a.m != b.n)
				return a;

			var res = new MatrixInt(a.n, b.m);

			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < b.m; j++)
					for (int k = 0; k < a.m; k++)
						res[i, j] += a[i, k] * b[k, j];

			return res;
		}

		public static MatrixInt operator /(MatrixInt a, int s) => Apply(a, s, (x, y) => y != 0 ? x / y : 0);
		public static MatrixInt operator %(MatrixInt a, int s) => Apply(a, s, (x, y) => y != 0 ? x % y : 0);

		// Bitwise
		public static MatrixInt operator |(MatrixInt a, MatrixInt b) => Apply(a, b, (x, y) => x | y);
		public static MatrixInt operator ^(MatrixInt a, MatrixInt b) => Apply(a, b, (x, y) => x ^ y);
		public static MatrixInt operator &(MatrixInt a, MatrixInt b) => Apply(a, b, (x, y) => x & y);

		public static MatrixInt operator >>(MatrixInt a, int s) => Apply(a, s, (x, y) => x >> y);
		public static MatrixInt operator <<(MatrixInt a, int s) => Apply(a, s, (x, y) => x << y);

		// Comparison
		public static bool operator ==(MatrixInt a, MatrixInt b)
		{
			if (a.n != b.n || a.m != b.m) return false;

			for (int i = 0; i < a.n; i++)
				for (int j = 0; j < a.m; j++)
					if (a[i, j] != b[i, j])
						return false;

			return true;
		}

		public static bool operator !=(MatrixInt a, MatrixInt b) => !(a == b);

		public static bool operator >(MatrixInt a, MatrixInt b)
		{
			for (int i = 0; i < Math.Min(a.n, b.n); i++)
				for (int j = 0; j < Math.Min(a.m, b.m); j++)
					if (a[i, j] <= b[i, j])
						return false;
			return true;
		}

		public static bool operator <(MatrixInt a, MatrixInt b)
		{
			for (int i = 0; i < Math.Min(a.n, b.n); i++)
				for (int j = 0; j < Math.Min(a.m, b.m); j++)
					if (a[i, j] >= b[i, j])
						return false;
			return true;
		}

		public static bool operator >=(MatrixInt a, MatrixInt b) => (a > b) || (a == b);
		public static bool operator <=(MatrixInt a, MatrixInt b) => (a < b) || (a == b);

		public override bool Equals(object? obj) => this == obj as MatrixInt;
		public override int GetHashCode() => IntArray.GetHashCode();
	}
}