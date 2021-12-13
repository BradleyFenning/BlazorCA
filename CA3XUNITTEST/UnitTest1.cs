using System;
using BlazorCA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CA3XUNITTEST.Test
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Test1()
        {
            GameName gn = new GameName();
            gn.internalName = "LEGOBATMAN";
            string expectedValue = "LEGOBATMAN";
            Assert.AreEqual(gn.internalName, expectedValue);
        }

        [TestMethod()]
        public void Test2()
        {
            Deal d = new Deal();
            d.price = "13.99";
            string expectedValue = "13.99";
            Assert.AreEqual(d.price, expectedValue);
        }
        [TestMethod()]
        public void Test3()
        {
            StoreName sn = new StoreName();
            sn.storeName = "AMAZON";
            string expectedValue = "AMAZON";
            Assert.AreEqual(sn.storeName, expectedValue);
        }
    }
}
