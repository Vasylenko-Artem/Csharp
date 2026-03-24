using Figures;

namespace tasks
{
	public class Task03
	{
		public static void Run()
		{
			Figure[] figures = new Figure[]
		{
			new Rectangle(4, 5),
			new Circle(3),
			new Triangle(3, 4, 5)
		};

			foreach (var fig in figures)
			{
				fig.Show();
			}

		}
	}
}
