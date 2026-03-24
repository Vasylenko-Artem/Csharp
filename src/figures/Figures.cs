namespace Figures
{
	public abstract class Figure
	{
		public string Name { get; set; }

		public Figure(string name)
		{
			Name = name;
		}

		// Абстрактні методи
		public abstract double Area();
		public abstract double Perimeter();

		public virtual void Show()
		{
			Console.WriteLine($"Figure: {Name}");
			Console.WriteLine($"Area: {Area():F2}");
			Console.WriteLine($"Perimeter: {Perimeter():F2}");
		}
	}
}