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
        public void TestMethod1()
        {
            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("en");

            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(It.IsAny<String>())).Returns(new DateTime());
            var taxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            var result = taxService.ApplyTax(10);

            Assert.AreEqual(12, result);
        }
    }
}
