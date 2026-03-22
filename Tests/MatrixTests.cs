using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Tests
{
	[TestClass]
	public class MatrixTests
	{
		[TestMethod]
		public void Add_Matrix_Matrix()
		{
			var m1 = new MatrixInt(2, 2, 2);
			var m2 = new MatrixInt(2, 2, 3);

			var res = m1 + m2;

			Assert.AreEqual(5, res[0, 0]);
			Assert.AreEqual(5, res[1, 1]);
		}

		[TestMethod]
		public void Multiply_Matrix_Matrix()
		{
			var m1 = new MatrixInt(2, 2, 1);
			var m2 = new MatrixInt(2, 2, 2);

			var res = m1 * m2;

			Assert.AreEqual(4, res[0, 0]);
		}

		[TestMethod]
		public void Indexer_Invalid_ShouldSetError()
		{
			var m = new MatrixInt(2, 2);

			var x = m[10, 10];

			Assert.AreEqual(-1, m.CodeError);
		}

		[TestMethod]
		public void Increment_ShouldWork()
		{
			var m = new MatrixInt(2, 2, 1);
			m++;

			Assert.AreEqual(2, m[0, 0]);
		}
	}
}