using Figures;
using Figures.Exceptions;

namespace tasks
{
	public class Task03
	{
		public static void Run()
		{
			try
			{
				IFigure[] figures = new IFigure[3];

				figures[0] = new Rectangle(4, 5);
				figures[1] = new Circle(3);

				// Error: Invalid triangle dimensions
				figures[2] = new Triangle(1, 2, 10);

				// Error: Array type mismatch
				object[] objArray = figures;
				objArray[0] = "Not a figure";

				foreach (var fig in figures)
				{
					fig.Show();
				}
			}
			catch (InvalidTriangleException ex)
			{
				Console.WriteLine($"Triangle error: {ex.Message}");
			}
			catch (InvalidDimensionException ex)
			{
				Console.WriteLine($"Dimension error: {ex.Message}");
			}
			catch (ArrayTypeMismatchException ex)
			{
				Console.WriteLine("Array type mismatch error!");
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("General error:");
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("\nProgram finished.");
			}
		}
	}
}