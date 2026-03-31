using Figures;

namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			FigureCollection collection = new FigureCollection();

			collection.Add(new Rectangle(4, 5));
			collection.Add(new Circle(3));
			collection.Add(new Triangle(3, 4, 5));

			foreach (var fig in collection)
			{
				fig.Show();
			}
		}
	}
}