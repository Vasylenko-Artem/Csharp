namespace Figures
{
	public class Point
	{
		// Protected fields
		protected int x;
		protected int y;
		protected int c;

		// Constructor: point with zero coordinates
		public Point()
		{
			x = 0;
			y = 0;
			c = 0;
		}

		// Constructor: point with given coordinates
		public Point(int x, int y, int color)
		{
			this.x = x;
			this.y = y;
			this.c = color;
		}

		// Property: get/set X coordinate
		public int X
		{
			get { return x; }
			set { x = value; }
		}

		// Property: get/set Y coordinate
		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		// Property: read-only color
		public int Color
		{
			get { return c; }
		}

		// Method: print coordinates
		public void Print()
		{
			Console.WriteLine($"Point: ({x}, {y})  Color: {c}");
		}

		// Method: calculate distance from origin
		public double DistanceFromOrigin()
		{
			return Math.Sqrt(x * x + y * y);
		}

		// Method: move point by vector (x1, y1)
		public void Move(int x1, int y1)
		{
			x += x1;
			y += y1;
		}
	}
}
