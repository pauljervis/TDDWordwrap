﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example.CountWords;

namespace CountWords.Tests
{
    [TestClass]
    public class CountingTests
    {
        [TestMethod]
        public void AnEmptyStringGivesNoWords()
        {
            //Arrange
            var service = new Counter();
            var expectedResult = 0;
            var input = "";

            //Act
            var actualResult = service.CountWords(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        //[TestMethod]
        //public void AStringWithNoSpacesGivesOneWord()
        //{
        //    var service = new Counter();
        //    var expectedResult = 1;
        //    var input = "hello";

        //    var actualResult = service.CountWords(input);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //// Remove usings

        //[TestMethod]
        //public void AStringWithOneSpaceGivesTwoWords()
        //{
        //    var service = new Counter();
        //    var expectedResult = 2;
        //    var input = "hello world";

        //    var actualResult = service.CountWords(input);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        ////Refactor - count spaces

        //[TestMethod]
        //public void AStringWithThreeWordsWithExtraSpacesStillGivesThree()
        //{
        //    var service = new Counter();
        //    var expectedResult = 3;
        //    var input = "hello from  York";

        //    var actualResult = service.CountWords(input);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

    }
}
