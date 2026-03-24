namespace Figures
{
	public class Rectangle : Figure
	{
		private double width;
		private double height;

		public Rectangle(double width, double height)
			: base("Rectangle")
		{
			this.width = width;
			this.height = height;
		}

		public override double Area()
		{
			return width * height;
		}

		public override double Perimeter()
		{
			return 2 * (width + height);
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine($"Width: {width}, Height: {height}");
			Console.WriteLine();
		}
	}
}