namespace Vector
{
	public class VectorInt
	{
		protected int[] IntArray;
		protected uint size;
		protected int codeError;
		protected static uint num_vec = 0;

		// Constructors
		public VectorInt()
		{
			size = 1;
			IntArray = new int[1];
			IntArray[0] = 0;
			num_vec++;
		}

		public VectorInt(uint size)
		{
			this.size = size;
			IntArray = new int[size];
			for (int i = 0; i < size; i++)
				IntArray[i] = 0;
			num_vec++;
		}

		public VectorInt(uint size, int value)
		{
			this.size = size;
			IntArray = new int[size];
			for (int i = 0; i < size; i++)
				IntArray[i] = value;
			num_vec++;
		}

		// Destructor
		~VectorInt()
		{
			Console.WriteLine("Vector destroyed");
		}

		// Methods
		public void Input()
		{
			for (int i = 0; i < size; i++)
			{
				Console.Write($"[{i}] = ");
				IntArray[i] = int.Parse(Console.ReadLine());
			}
		}

		public void Print()
		{
			for (int i = 0; i < size; i++)
				Console.Write(IntArray[i] + " ");
			Console.WriteLine();
		}

		public void SetAll(int value)
		{
			for (int i = 0; i < size; i++)
				IntArray[i] = value;
		}

		public static uint CountVectors()
		{
			return num_vec;
		}

		// Properties
		public uint Size => size;

		public int CodeError
		{
			get { return codeError; }
			set { codeError = value; }
		}

		// Indexer
		public int this[int index]
		{
			get
			{
				if (index >= 0 && index < size)
					return IntArray[index];

				codeError = -1;
				return 0;
			}
			set
			{
				if (index >= 0 && index < size)
					IntArray[index] = value;
				else
					codeError = -1;
			}
		}

		// Unary
		public static VectorInt operator ++(VectorInt v)
		{
			for (int i = 0; i < v.size; i++)
				v.IntArray[i]++;
			return v;
		}

		public static VectorInt operator --(VectorInt v)
		{
			for (int i = 0; i < v.size; i++)
				v.IntArray[i]--;
			return v;
		}

		public static bool operator true(VectorInt v)
		{
			if (v.size == 0) return false;

			foreach (var x in v.IntArray)
				if (x == 0) return false;

			return true;
		}

		public static bool operator false(VectorInt v)
		{
			return !(v);
		}

		public static bool operator !(VectorInt v)
		{
			return v.size != 0;
		}

		public static VectorInt operator ~(VectorInt v)
		{
			VectorInt res = new VectorInt(v.size);
			for (int i = 0; i < v.size; i++)
				res.IntArray[i] = ~v.IntArray[i];
			return res;
		}

		// General logic for binary operations
		private static VectorInt Apply(VectorInt a, VectorInt b, Func<int, int, int> op)
		{
			uint max = Math.Max(a.size, b.size);
			uint min = Math.Min(a.size, b.size);

			VectorInt res = new VectorInt(max);

			for (int i = 0; i < min; i++)
				res.IntArray[i] = op(a.IntArray[i], b.IntArray[i]);

			return res;
		}

		private static VectorInt Apply(VectorInt a, int scalar, Func<int, int, int> op)
		{
			VectorInt res = new VectorInt(a.size);
			for (int i = 0; i < a.size; i++)
				res.IntArray[i] = op(a.IntArray[i], scalar);
			return res;
		}

		// Arithmetic
		public static VectorInt operator +(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => x + y);
		public static VectorInt operator +(VectorInt a, int s) => Apply(a, s, (x, y) => x + y);

		public static VectorInt operator -(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => x - y);
		public static VectorInt operator -(VectorInt a, int s) => Apply(a, s, (x, y) => x - y);

		public static VectorInt operator *(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => x * y);
		public static VectorInt operator *(VectorInt a, int s) => Apply(a, s, (x, y) => x * y);

		public static VectorInt operator /(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => y != 0 ? x / y : 0);
		public static VectorInt operator /(VectorInt a, int s) => Apply(a, s, (x, y) => y != 0 ? x / y : 0);

		public static VectorInt operator %(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => y != 0 ? x % y : 0);
		public static VectorInt operator %(VectorInt a, int s) => Apply(a, s, (x, y) => y != 0 ? x % y : 0);

		// Bitwise
		public static VectorInt operator |(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => x | y);
		public static VectorInt operator |(VectorInt a, int s) => Apply(a, s, (x, y) => x | y);

		public static VectorInt operator ^(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => x ^ y);
		public static VectorInt operator ^(VectorInt a, int s) => Apply(a, s, (x, y) => x ^ y);

		public static VectorInt operator &(VectorInt a, VectorInt b) => Apply(a, b, (x, y) => x & y);
		public static VectorInt operator &(VectorInt a, int s) => Apply(a, s, (x, y) => x & y);

		public static VectorInt operator >>(VectorInt a, int s) => Apply(a, s, (x, y) => x >> y);
		public static VectorInt operator <<(VectorInt a, int s) => Apply(a, s, (x, y) => x << y);

		// Comparison
		public static bool operator ==(VectorInt a, VectorInt b)
		{
			uint min = Math.Min(a.size, b.size);
			for (int i = 0; i < min; i++)
				if (a.IntArray[i] != b.IntArray[i])
					return false;
			return true;
		}

		public static bool operator !=(VectorInt a, VectorInt b) => !(a == b);

		public static bool operator >(VectorInt a, VectorInt b)
		{
			uint min = Math.Min(a.size, b.size);
			for (int i = 0; i < min; i++)
				if (a.IntArray[i] <= b.IntArray[i])
					return false;
			return true;
		}

		public static bool operator <(VectorInt a, VectorInt b)
		{
			uint min = Math.Min(a.size, b.size);
			for (int i = 0; i < min; i++)
				if (a.IntArray[i] >= b.IntArray[i])
					return false;
			return true;
		}

		public static bool operator >=(VectorInt a, VectorInt b) => (a > b) || (a == b);
		public static bool operator <=(VectorInt a, VectorInt b) => (a < b) || (a == b);

		public override bool Equals(object? obj)
		{
			return this == obj as VectorInt;
		}

		public override int GetHashCode()
		{
			return IntArray.GetHashCode();
		}
	}
}