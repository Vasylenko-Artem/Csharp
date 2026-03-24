namespace Figures
{
	public class Triangle : Figure
	{
		private double a, b, c;

		public Triangle(double a, double b, double c)
			: base("Triangle")
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}

		public override double Perimeter()
		{
			return a + b + c;
		}

		public override double Area()
		{
			// Формула Герона
			double p = Perimeter() / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine($"Sides: {a}, {b}, {c}");
			Console.WriteLine();
		}
	}
}