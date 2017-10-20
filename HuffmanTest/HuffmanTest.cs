using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuffmanLib;

namespace HuffmanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEncoder()
        {
            var encoder = new Encoder();
            encoder.AddSymbol(45);
            encoder.AddSymbol(16);
            encoder.AddSymbol(13);
            encoder.AddSymbol(12);
            encoder.AddSymbol(9);
            encoder.AddSymbol(5);
            encoder.Encode();
            Assert.AreEqual(4, encoder.MaxWordLength);
            Assert.AreEqual(1, encoder.MinWordLength);
        }
    }
}
