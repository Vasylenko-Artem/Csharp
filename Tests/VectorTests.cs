using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vector;

namespace Tests
{
	[TestClass]
	public class VectorTests
	{
		[TestMethod]
		public void Add_Vector_Vector()
		{
			var v1 = new VectorInt(3, 2);
			var v2 = new VectorInt(3, 3);

			var res = v1 + v2;

			Assert.AreEqual(5, res[0]);
			Assert.AreEqual(5, res[1]);
			Assert.AreEqual(5, res[2]);
		}

		[TestMethod]
		public void Add_Vector_Scalar()
		{
			var v = new VectorInt(3, 1);
			var res = v + 2;

			Assert.AreEqual(3, res[0]);
		}

		[TestMethod]
		public void Indexer_InvalidIndex_ShouldSetError()
		{
			var v = new VectorInt(3);

			var x = v[100];

			Assert.AreEqual(-1, v.CodeError);
		}

		[TestMethod]
		public void Increment_ShouldIncreaseAll()
		{
			var v = new VectorInt(3, 1);
			v++;

			Assert.AreEqual(2, v[0]);
			Assert.AreEqual(2, v[1]);
			Assert.AreEqual(2, v[2]);
		}
	}
}