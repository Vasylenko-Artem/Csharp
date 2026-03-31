namespace Figures
{
	public abstract class FigureBase : IFigure
	{
		public string Name { get; protected set; }

		public FigureBase(string name)
		{
			Name = name;
		}

		public abstract double Area();
		public abstract double Perimeter();

		public virtual void Show()
		{
			Console.WriteLine($"Figure: {Name}");
			Console.WriteLine($"Area: {Area():F2}");
			Console.WriteLine($"Perimeter: {Perimeter():F2}");
		}

		public int CompareTo(IFigure other)
		{
			return this.Area().CompareTo(other.Area());
		}

		public abstract object Clone();
	}
}