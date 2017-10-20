using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HuffmanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var encoder = new Encoder();
            encoder.AddSymbol(32);
            encoder.AddSymbol(25);
            encoder.AddSymbol(20);
            encoder.AddSymbol(18);
            encoder.AddSymbol(5);
            encoder.Encode();
            Assert.AreEqual(4, encoder.MaxWordLength);
            Assert.AreEqual(2, encoder.MaxWordLength);
        }
    }
}
