using Figures.Exceptions;

namespace Figures
{
	public class Rectangle : FigureBase
	{
		private double width, height;

		public Rectangle(double width, double height) : base("Rectangle")
		{
			if (width <= 0 || height <= 0)
				throw new InvalidDimensionException("Width and height must be > 0");

			this.width = width;
			this.height = height;
		}

		public override double Area() => width * height;
		public override double Perimeter() => 2 * (width + height);

		public override void Show()
		{
			base.Show();
			Console.WriteLine($"Width: {width}, Height: {height}\n");
		}

		public override object Clone() => new Rectangle(width, height);
	}
}