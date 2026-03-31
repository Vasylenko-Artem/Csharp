namespace Figures.Exceptions
{
	public class InvalidFigureException : Exception
	{
		public InvalidFigureException(string message) : base(message) { }
	}

	public class InvalidDimensionException : InvalidFigureException
	{
		public InvalidDimensionException(string message) : base(message) { }
	}

	public class InvalidTriangleException : InvalidFigureException
	{
		public InvalidTriangleException(string message) : base(message) { }
	}
}