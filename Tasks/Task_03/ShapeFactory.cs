using System;

namespace MyApp.Tasks.Task03;

public static class ShapeFactory
{
	public static Figure CreateRandom(Random rnd)
	{
		return rnd.Next(4) switch
		{
			0 => new Square(),
			1 => new RectangleFigure(),
			2 => new EllipseFigure(),
			_ => new Rhombus()
		};
	}
}