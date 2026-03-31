namespace Figures
{
	public interface IFigure : IComparable<IFigure>, ICloneable
	{
		string Name { get; }
		double Area();
		double Perimeter();
		void Show();
	}
}