using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RomanConverterTests
    {
    [TestClass]
    public class UnitTest1
        {
        [TestMethod]
        public void RomanTest()
            {
            Assert.ThrowsException<ArgumentException>(() => { RomanConverter.RomanConverter.ToRoman(-100); });
            Assert.ThrowsException<ArgumentException>(() => { RomanConverter.RomanConverter.ToRoman(0); });
            Assert.ThrowsException<ArgumentException>(() => { RomanConverter.RomanConverter.ToRoman(4001); });
            Assert.AreEqual("I", RomanConverter.RomanConverter.ToRoman(1));
            Assert.AreEqual("II", RomanConverter.RomanConverter.ToRoman(2));
            Assert.AreEqual("IV", RomanConverter.RomanConverter.ToRoman(4));
            Assert.AreEqual("V", RomanConverter.RomanConverter.ToRoman(5));
            Assert.AreEqual("VII", RomanConverter.RomanConverter.ToRoman(7));
            Assert.AreEqual("IX", RomanConverter.RomanConverter.ToRoman(9));
            Assert.AreEqual("X", RomanConverter.RomanConverter.ToRoman(10));
            Assert.AreEqual("XI", RomanConverter.RomanConverter.ToRoman(11));
            Assert.AreEqual("XLIX", RomanConverter.RomanConverter.ToRoman(49));
            Assert.AreEqual("L", RomanConverter.RomanConverter.ToRoman(50));
            Assert.AreEqual("LI", RomanConverter.RomanConverter.ToRoman(51));
            Assert.AreEqual("XCIX", RomanConverter.RomanConverter.ToRoman(99));
            Assert.AreEqual("C", RomanConverter.RomanConverter.ToRoman(100));
            Assert.AreEqual("CMXCIX", RomanConverter.RomanConverter.ToRoman(999));
            Assert.AreEqual("M", RomanConverter.RomanConverter.ToRoman(1000));
            Assert.AreEqual("MM", RomanConverter.RomanConverter.ToRoman(2000));
            Assert.AreEqual("MCMLXXXIX", RomanConverter.RomanConverter.ToRoman(1989));
            Assert.AreEqual("MMMM", RomanConverter.RomanConverter.ToRoman(4000));
            Assert.AreEqual("MMMCM", RomanConverter.RomanConverter.ToRoman(3900));
            }
        }
    }
