using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TaxService
{
    [TestClass]
    public class TaxServiceTest
    {
        [TestMethod]
        public void Should_Return_20_When_2021()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(new DateTime(2020, 7, 19));
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.2m, taxservice.GetTax(new DateTime(2021, 1, 1)));
        }
		
		
		[TestMethod]
        public void Should_Not_Return_20_When_2019()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(new DateTime(2020, 7, 19));
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreNotEqual(0.2m, taxservice.GetTax(new DateTime(2019, 12, 30)));
			//или лучше сделать проверку, что будет равно 0.3?
			//Assert.AreEqual(0.3m, taxservice.GetTax(new DateTime(2019, 12, 30)));
        }
		
				
        [TestMethod]
        public void Should_Return_30_When_2001()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(new DateTime(2020, 7, 19));
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.3m, taxservice.GetTax(new DateTime(2001, 1, 1)));
        }
		
		
        [TestMethod]
        public void Should_Return_15_When_1999()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(new DateTime(2020, 7, 19));
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.15m, taxservice.GetTax(new DateTime(1999, 12, 30)));
        }


		[TestMethod]
        public void Should_Return_15_When_1000()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(new DateTime(2020, 7, 19));
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.15m, taxservice.GetTax(new DateTime(1000, 1, 1)));
        }

        
        [TestMethod]
        public void Should_Return_1_When_Considered_08_When_Now()
        {
            var stubIUserService = new Mock<IUserService>();
            var stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(new DateTime(2020, 7, 19));
            var taxservice = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
            Assert.AreEqual(0.96m, taxservice.ApplyTax(0.8m));
        }
    }
}
