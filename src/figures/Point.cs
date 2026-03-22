namespace Figures
{
	public class Point
	{
		protected int x;
		protected int y;
		protected int c;

		public Point()
		{
			x = 0;
			y = 0;
			c = 0;
		}

		public Point(int x, int y, int color)
		{
			this.x = x;
			this.y = y;
			this.c = color;
		}

		public int X
		{
			get { return x; }
			set { x = value; }
		}

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int Color
		{
			get { return c; }
		}

		// Індексатор
		public int this[int index]
		{
			get
			{
				return index switch
				{
					0 => x,
					1 => y,
					2 => c,
					_ => throw new IndexOutOfRangeException("Invalid index! Use 0 (x), 1 (y), 2 (color)")
				};
			}
			set
			{
				switch (index)
				{
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: c = value; break;
					default: throw new IndexOutOfRangeException("Invalid index! Use 0 (x), 1 (y), 2 (color)");
				}
			}
		}

		public void Print()
		{
			Console.WriteLine($"Point: ({x}, {y})  Color: {c}");
		}

		public double DistanceFromOrigin()
		{
			return Math.Sqrt(x * x + y * y);
		}

		public void Move(int x1, int y1)
		{
			x += x1;
			y += y1;
		}

		// ++
		public static Point operator ++(Point p)
		{
			p.x++;
			p.y++;
			return p;
		}

		// --
		public static Point operator --(Point p)
		{
			p.x--;
			p.y--;
			return p;
		}

		// true
		public static bool operator true(Point p)
		{
			return p.x == p.y;
		}

		// false
		public static bool operator false(Point p)
		{
			return p.x != p.y;
		}

		// +
		public static Point operator +(Point p, int scalar)
		{
			return new Point(p.x + scalar, p.y + scalar, p.c);
		}

		// Point -> string
		public static explicit operator string(Point p)
		{
			return $"{p.x},{p.y},{p.c}";
		}

		// string -> Point
		public static explicit operator Point(string str)
		{
			var parts = str.Split(',');
			if (parts.Length != 3)
				throw new FormatException("String must be in format: x,y,color");

			return new Point(
				int.Parse(parts[0]),
				int.Parse(parts[1]),
				int.Parse(parts[2])
			);
		}
	}
}