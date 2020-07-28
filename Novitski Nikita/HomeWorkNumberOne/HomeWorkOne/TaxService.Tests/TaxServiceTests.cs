using System;
using HomeWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TaxService.Tests
{
    [TestClass]
    public class TaxServiceTests
    {
        static Mock<IDateTimeService> mockDateTimeService;
        static Mock<IUserService> mockUserService;
        static TaxService1 taxService;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext context)
        {
            mockDateTimeService = new Mock<IDateTimeService>();
            mockUserService = new Mock<IUserService>();

            mockUserService.Setup(x => x.GetUiCulture()).Returns("RU-ru");
            mockDateTimeService.Setup(x => x.GetCurrentDate(It.IsNotNull<string>())).Returns(It.IsAny<DateTime>());

            taxService = new TaxService1(mockDateTimeService.Object, mockUserService.Object);
        }


        [TestMethod]
        public void GetTax_EnterYear2020_return0_2()
        {
            Assert.AreEqual(0.2m, taxService.GetTax(new DateTime(2020, 01, 01)));
        }

        [TestMethod]
        public void GetTax_EnterYear2019_return0_3()
        {
            Assert.AreEqual(0.3m, taxService.GetTax(new DateTime(2019, 01, 01)));
        }

        [TestMethod]
        public void GetTax_EnterYear2001_return0_3()
        {
            Assert.AreEqual(0.3m, taxService.GetTax(new DateTime(2001, 01, 01)));
        }

        [TestMethod]
        public void GetTax_EnterYear2000_return0_15()
        {
            Assert.AreEqual(0.3m, taxService.GetTax(new DateTime(2000, 01, 01)));
        }

        [TestMethod]
        public void GetTax_EnterLessThan2000Years_return0_15()
        {
            Assert.AreEqual(0.15m, taxService.GetTax(new DateTime(1999, 01, 01)));
        }

        [TestMethod]
        public void ApplyTax_Enter100_return115()
        {
            Assert.AreEqual(115m, taxService.ApplyTax(100));
        }


    }
}
