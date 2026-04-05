using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia;

namespace MyApp.Tasks.Task03;

public class Rhombus : Figure
{
	public override void Draw(Canvas canvas)
	{
		var poly = new Polygon
		{
			Points = new Points
			{
				new Point(X + Size1/2, Y),
				new Point(X + Size1, Y + Size2/2),
				new Point(X + Size1/2, Y + Size2),
				new Point(X, Y + Size2/2)
			},
			Fill = Color
		};

		canvas.Children.Add(poly);
	}
}