using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PArray.Test
{
    [TestClass]
    public class PArrayTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            PArray<int> pa = new PArray<int>(new List<int> { 1,2,3,4});
            Assert.IsNotNull(pa);
        }

        [TestMethod]
        public void PushOneTest()
        {
            PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
            pa.Push(5);
            Assert.AreEqual(5, pa.Count);
        }

        [TestMethod]
        public void PopOneTest()
        {
            PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
            var i = pa.Pop();
            Assert.AreEqual(3, pa.Count);
            Assert.AreEqual(4, i);
        }

        [TestMethod]
        public void UnshiftOneTest()
        {
            PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
            pa.Unshift(5);
            Assert.AreEqual(5, pa.Count);
            int i = pa.Pop();
            Assert.AreEqual(4, i);

        }

        [TestMethod]
        public void ShiftOneTest()
        {
            PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
            var i = pa.Shift();
            Assert.AreEqual(3, pa.Count);
            Assert.AreEqual(1, i);
        }

    }
}
