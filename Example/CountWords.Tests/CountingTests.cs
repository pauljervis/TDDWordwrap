using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example.CountWords;

namespace CountWords.Tests
{
    [TestClass]
    public class CountingTests
    {
        [TestMethod]
        public void WhenGivenAnEmptyStringReturnZero()
        {
            var service = new Counter();
            var expectedResult = 0;
            var input = "";

            var actualResult = service.CountWords(input);
            Assert.AreEqual(expectedResult, actualResult);
        }


        //[TestMethod]
        //public void WhenGivenASingleWordReturnOne()
        //{
        //    var service = new Counter();
        //    var expectedResult = 1;
        //    var input = "hello";

        //    var actualResult = service.CountWords(input);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //// Remove usings

        //[TestMethod]
        //public void WhenGivenTwoWordsReturnTwo()
        //{
        //    var service = new Counter();
        //    var expectedResult = 2;
        //    var input = "hello world";

        //    var actualResult = service.CountWords(input);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        ////Refactor - count spaces

        //[TestMethod]
        //public void WhenGivenThreeWordsWithExtraSpacesStillReturnThree()
        //{
        //    var service = new Counter();
        //    var expectedResult = 3;
        //    var input = "hello from  York";

        //    var actualResult = service.CountWords(input);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

    }
}
