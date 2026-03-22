using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace Tests
{
	[TestClass]
	public class PointTests
	{
		[TestMethod]
		public void Indexer_ShouldReturnCorrectValues()
		{
			var p = new Point(1, 2, 3);

			Assert.AreEqual(1, p[0]);
			Assert.AreEqual(2, p[1]);
			Assert.AreEqual(3, p[2]);
		}

		[TestMethod]
		public void PlusOperator_ShouldAddScalar()
		{
			var p = new Point(1, 2, 0);
			var res = p + 5;

			Assert.AreEqual(6, res.X);
			Assert.AreEqual(7, res.Y);
		}

		[TestMethod]
		public void TrueOperator_ShouldWork()
		{
			var p = new Point(2, 2, 0);

			if (p)
				Assert.IsTrue(true);
			else
				Assert.Fail();
		}
	}
}