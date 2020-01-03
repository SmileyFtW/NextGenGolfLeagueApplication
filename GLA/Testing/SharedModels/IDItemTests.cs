using GLA.Interfaces;
using GLA.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Testing.SharedModels
{
    [TestFixture]
    class IDItemTests
    {
        [Test]
        public void IDItem_GetIDNoPrefix_ReturnsNoPrefix()
        {
            string prefix = "";
            string sep = "sep";
            int segNo = 1;
            int numDigits = 2;

            IDItem iDItem = new IDItem(prefix,sep, segNo, numDigits);
            string result = iDItem.ID;

            Assert.AreEqual("No Prefix", result);
        }

        [Test]
        public void IDItem_GetIDNoSeparator_ReturnsNoSeparator()
        {
            string prefix = "pre";
            string sep = "";
            int segNo = 1;
            int numDigits = 2;

            IDItem iDItem = new IDItem(prefix, sep, segNo, numDigits);
            string result = iDItem.ID;

            Assert.AreEqual("No Separator", result);
        }

        [Test]
        public void IDItem_GetIDNoPrefixNoSeparator_ReturnsNoPrefixNoSeparator()
        {
            string prefix = "";
            string sep = "";
            int segNo = 1;
            int numDigits = 2;

            IDItem iDItem = new IDItem(prefix, sep, segNo, numDigits);
            string result = iDItem.ID;

            Assert.AreEqual("No Prefix and No Separator", result, result);

        }

        [Test]
        public void IDItem_GetIDValidInput_ReturnsTrue()
        {
            string prefix = "pre";
            string sep = "sep";
            int seqNo = 1;
            int numDigits = 2;
            string expectedOutput = prefix + sep + seqNo.ToString().PadLeft(numDigits, '0');

            IDItem iDItem = new IDItem(prefix, sep, seqNo, numDigits);
            string result = iDItem.ID;

            Assert.AreEqual(expectedOutput, result, result);
        }

        [Test]
        public void IDITem_GetIDIncompatibleSegNoNumDigits_ReturnsIncompatibility()
        {
            string prefix = "pre";
            string sep = "sep";
            int segNo = 99;
            int numDigits = 1;
            string expectedOutput = "Seq Number (" + segNo + ") incompatible with Number of Digits (" + numDigits + ")";
            IDItem iDItem = new IDItem(prefix, sep, segNo, numDigits);
            string result = iDItem.ID;

            Assert.AreEqual(expectedOutput, result);

        }

        [Test]
        public void IDItem_InputIsEmptyOrNull_ReturnsTrue(
            [Values(null,"")] string input)
        {
            IDItem iDItem = new IDItem();
            bool result = iDItem.InputIsEmpty(input);

            Assert.IsTrue(result);
        }

        [Test]
        public void IDItem_NumDigitsCompatibilityWithSeqNumber_SeqNoLengthSmallerThanNumDigitsPlus1_ReturnsTrue()
        {
            int SeqNo = 99;
            int NumDigits = 3;
            IDItem idItem = new IDItem();

            bool result = idItem.SeqNumberCompatibleWithNumberOfDigits(SeqNo, NumDigits);

            Assert.IsTrue(result);
        }

        [Test]
        public void IDItem_NumDigitsCompatibilityWithSeqNumber_SeqNoLengthEqualToNumDigitsPlus1_ReturnsTrue()
        {
            int SeqNo = 99;
            int NumDigits = 2;
            IDItem idItem = new IDItem();

            bool result = idItem.SeqNumberCompatibleWithNumberOfDigits(SeqNo, NumDigits);

            Assert.IsTrue(result);
        }

        [Test]
        public void IDItem_NumDigitsCompatibilityWithSeqNumber_SeqNoLengthGreaterThanNumDigitsPlus1_ReturnsFalse()
        {
            int SeqNo = 99;
            int NumDigits = 1;
            IDItem idItem = new IDItem();

            bool result = idItem.SeqNumberCompatibleWithNumberOfDigits(SeqNo, NumDigits);

            Assert.IsFalse(result);
        }
    }
}
