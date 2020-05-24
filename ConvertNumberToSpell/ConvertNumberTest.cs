using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConvertNumberToSpeak;
namespace ConvertNumberToSpellTest
{
    [TestClass]
    public class ConvertNumberTest
    {

        ConvertNumToWords objConvert = new ConvertNumToWords();

        [TestMethod]
        public void should_return_thousand_display_for_given_input()
        {

            long longInput = 5435;
            string strExpected = "five thousand four hundred and thirty five ";
            string strActual = objConvert.convertToWords(longInput);
            Assert.AreEqual(strExpected, strActual);
        }

        [TestMethod]
        public void should_return_lakh_display_for_given_input()
        {

            long longInput = 300005;
            string strExpected = "three lakh and five ";
            string strActual = objConvert.convertToWords(longInput);
            Assert.AreEqual(strExpected, strActual);
        }

        [TestMethod]
        public void should_return_core_display_for_given_input()
        {

            long longInput = 30000005;
            string strExpected = "three crore and five ";
            string strActual = objConvert.convertToWords(longInput);
            Assert.AreEqual(strExpected, strActual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void should_return_exception_for_negative_input()
        {
            long longInput = -123;
            string strActual = objConvert.convertToWords(longInput);
        }
    }
}
