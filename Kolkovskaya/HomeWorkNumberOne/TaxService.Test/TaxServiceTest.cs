using System;
using HW1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TaxServiceTest
{
    [TestClass]
    public class TaxServiceTest
    {
        [TestMethod]
        public void TestMoreOrEqual2020()
        {
            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("en");

            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(It.IsAny<String>())).Returns(new DateTime());
            var taxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            var result = taxService.ApplyTax(10);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestMore2000AndLess2020()
        {
            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("en");

            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(It.IsAny<String>())).Returns(new DateTime(2001, 12, 1));
            var taxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            var result = taxService.ApplyTax(10);

            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void TestLess2000()
        {
            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("en");

            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(It.IsAny<String>())).Returns(new DateTime(1998, 12, 1));
            var taxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            var result = taxService.ApplyTax(10);

            Assert.AreEqual(11.5, result);
        }
    }
}
