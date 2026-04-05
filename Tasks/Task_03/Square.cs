using Avalonia.Controls;
using Avalonia.Controls.Shapes;

namespace MyApp.Tasks.Task03;

public class Square : Figure
{
	public override void Draw(Canvas canvas)
	{
		var rect = new Rectangle
		{
			Width = Size1,
			Height = Size1,
			Fill = Color
		};

		Canvas.SetLeft(rect, X);
		Canvas.SetTop(rect, Y);
		canvas.Children.Add(rect);
	}
}