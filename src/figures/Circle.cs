using Figures.Exceptions;

namespace Figures
{
	public class Circle : FigureBase
	{
		private double radius;

		public Circle(double radius) : base("Circle")
		{
			if (radius <= 0)
				throw new InvalidDimensionException("Radius must be > 0");

			this.radius = radius;
		}

		public override double Area() => Math.PI * radius * radius;
		public override double Perimeter() => 2 * Math.PI * radius;

		public override void Show()
		{
			base.Show();
			Console.WriteLine($"Radius: {radius}\n");
		}

		public override object Clone() => new Circle(radius);
	}
}