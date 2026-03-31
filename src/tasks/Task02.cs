using Figures;

namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			IFigure[] figures =
			{
				new Rectangle(4, 5),
				new Circle(3),
				new Triangle(3, 4, 5)
			};

			Array.Sort(figures);

			foreach (var fig in figures)
			{
				fig.Show();
			}
		}
	}
}