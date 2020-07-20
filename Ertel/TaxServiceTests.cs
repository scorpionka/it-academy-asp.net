using System;
using HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HomeWorkTests
{
    [TestClass]
    public class TaxServiceTests
    {

        private TaxService taxService;

        private TaxService GetTaxService()
        {
            if (taxService != null) return taxService;

            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("ru");

            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate("ru")).Returns(DateTime.Now);

            taxService = new TaxService(stubDateTimeService.Object, stubUserService.Object as IUserService);

            return taxService;
        }

            [TestMethod]
        public void Should_GetTax_Return_0_2()
        {

            DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
            Assert.AreEqual(0.2m, GetTaxService().GetTax(startOfYear));

        }

        public void Should_GetTax_Return_0_3()
        {

            DateTime startOfYear = new DateTime(2001, 1, 1);
            Assert.AreEqual(0.3m, GetTaxService().GetTax(startOfYear));

        }

        public void Should_GetTax_Return_0_15()
        {

            DateTime startOfYear = new DateTime(2000, 1, 1);
            Assert.AreEqual(0.15m, GetTaxService().GetTax(startOfYear));

        }

        public void Should_ApplyTax_Return_0_2()
        {

            DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
            Assert.AreEqual(0.2m, GetTaxService().ApplyTax(1m));

        }

    }
}
