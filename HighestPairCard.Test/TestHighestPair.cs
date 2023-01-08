using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighestPairCard;
using System.Collections.Generic;

namespace HighestPairCard.Test
{
    [TestClass]
    public class TestHighestPair
    {
        private readonly HighestCard _highestCard;

        public TestHighestPair()
        {
            _highestCard = new HighestCard();
        }
        //To test Functionalities
        [TestMethod]
        [DataRow(new string[] { "A", "A", "Q", "Q", "6" })]        
        public void Test_highestPair_ValidReturnTypeDict(string[] inp)
        {
            Dictionary<bool, string> expected = new Dictionary<bool, string>();
            expected.Add(true, "A");
            var actual = _highestCard.highestPair(inp);

            CollectionAssert.AreEqual(expected, actual);            
        }

        [TestMethod]
        [DataRow(new string[] { "J", "6", "3", "10", "8" })]        
        public void Test_highestPair_ValidReturnTypeBool(string[] inp)
        {
            bool expected = false;
            var actual = _highestCard.highestPair(inp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new string[] { "3", "5", "5", "5", "5" })]
        public void Test_highestPair_ValidReturnTypeDicFrRepeatMoreThan2(string[] inp)
        {
            Dictionary<bool, string> expected = new Dictionary<bool, string>();
            expected.Add(true, "5");
            var actual = _highestCard.highestPair(inp);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
