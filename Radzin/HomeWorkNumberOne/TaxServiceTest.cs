using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ItAcademy.HomeWork.NumberOne.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_GetTax_Return_Twenty_Percent()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("Ru");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("Ru")).Returns(DateTime.Now);
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.2m, taxservice.GetTax(DateTime.Now));
        }
        [TestMethod]
        public void Should_GetTax_Return_Thirty_Percent()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("Ru");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("Ru")).Returns(DateTime.Now);
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.3m, taxservice.GetTax(new DateTime(2002, 8, 18)));
        }
        [TestMethod]
        public void Should_GetTax_Return_Fifteen_Percent()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("Ru");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("Ru")).Returns(DateTime.Now);
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.15m, taxservice.GetTax(new DateTime(1999, 8, 18)));
        }
      
        [TestMethod]
        public void Discount_Apply()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("Ru");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("Ru")).Returns(DateTime.Now);
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(1.2m, taxservice.ApplyTax(1m));
        }
    }
}
