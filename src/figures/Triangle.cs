using Figures.Exceptions;

namespace Figures
{
	public class Triangle : FigureBase
	{
		private double a, b, c;

		public Triangle(double a, double b, double c) : base("Triangle")
		{
			if (a <= 0 || b <= 0 || c <= 0)
				throw new InvalidDimensionException("Sides must be > 0");

			if (a + b <= c || a + c <= b || b + c <= a)
				throw new InvalidTriangleException("Triangle inequality violated");

			this.a = a;
			this.b = b;
			this.c = c;
		}

		public override double Perimeter() => a + b + c;

		public override double Area()
		{
			double p = Perimeter() / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine($"Sides: {a}, {b}, {c}\n");
		}

		public override object Clone() => new Triangle(a, b, c);
	}
}