namespace Figures
{
	public class Circle : Figure
	{
		private double radius;

		public Circle(double radius)
			: base("Circle")
		{
			this.radius = radius;
		}

		public override double Area()
		{
			return Math.PI * radius * radius;
		}

		public override double Perimeter()
		{
			return 2 * Math.PI * radius;
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine($"Radius: {radius}");
			Console.WriteLine();
		}
	}
}