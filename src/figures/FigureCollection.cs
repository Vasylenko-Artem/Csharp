using System.Collections;

namespace Figures
{
	public class FigureCollection : IEnumerable<IFigure>
	{
		private List<IFigure> figures = new List<IFigure>();

		public void Add(IFigure figure)
		{
			figures.Add(figure);
		}

		public IEnumerator<IFigure> GetEnumerator()
		{
			return figures.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}