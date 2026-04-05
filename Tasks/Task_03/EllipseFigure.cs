using Avalonia.Controls;
using Avalonia.Controls.Shapes;

namespace MyApp.Tasks.Task03;

public class EllipseFigure : Figure
{
	public override void Draw(Canvas canvas)
	{
		var ell = new Ellipse
		{
			Width = Size1,
			Height = Size2,
			Fill = Color
		};

		Canvas.SetLeft(ell, X);
		Canvas.SetTop(ell, Y);
		canvas.Children.Add(ell);
	}
}