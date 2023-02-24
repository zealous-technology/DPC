using DPC.Web.Extensions;

namespace DPC.Test
{
    [TestClass]
    public class CustomExtensionTests
    {
        [TestMethod]
        public void Test_GetFirstItem_ShouldReturnAA()
        {
            Assert.AreEqual(new[] { "GH", "ZZ", "AA", "AB", "PL" }.GetFirstItem(items => items.OrderBy(i => i)), "AA");
        }

        [TestMethod]
        public void Test_GetFirstItem_ShouldReturnZZ()
        {
            Assert.AreEqual(new[] { "GH", "ZZ", "AA", "AB", "PL" }.GetFirstItem(items => items.OrderByDescending(i => i)), "ZZ");
        }

        [TestMethod]
        public void Test_GetFirstItem_ShouldReturn1()
        {
            Assert.AreEqual(new[] { 5, 2, 1, 7, 3 }.GetFirstItem(items => items.OrderBy(i => i)), 1);
        }

        [TestMethod]
        public void Test_GetFirstItem_ShouldReturn7()
        {
            Assert.AreEqual(new[] { 5, 2, 1, 7, 3 }.GetFirstItem(items => items.OrderByDescending(i => i)), 7);
        }

        [TestMethod]
        public void Test_GetFirstItem_ShouldReturn3()
        {
            Assert.AreEqual(new[] { 5, 2, 1, 7, 3 }.GetFirstItem(items => items.Reverse()), 3);
        }
    }
}