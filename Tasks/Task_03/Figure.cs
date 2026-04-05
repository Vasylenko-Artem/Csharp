using Avalonia.Controls;
using Avalonia.Media;

namespace MyApp.Tasks.Task03;

public abstract class Figure
{
	public double X, Y;
	public double Size1, Size2;
	public IBrush Color;

	public abstract void Draw(Canvas canvas);

	public virtual void Move(double dx, double dy)
	{
		X += dx;
		Y += dy;
	}

	public void Clamp(double maxWidth, double maxHeight)
	{
		if (X < 0) X = 0;
		if (Y < 0) Y = 0;

		if (X + Size1 > maxWidth) X = maxWidth - Size1;
		if (Y + Size2 > maxHeight) Y = maxHeight - Size2;
	}
}