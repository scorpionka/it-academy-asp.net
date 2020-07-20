using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace HW1.Tests
{
    [TestClass]
    public class HW1Tests
    {
        private static Mock<IUserService> stubIUserService;
        private static Mock<IDateTimeService> stubIDateTimeService;
        private static TaxService taxService;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            stubIUserService = new Mock<IUserService>();
            stubIDateTimeService = new Mock<IDateTimeService>();
            stubIUserService.Setup(x => x.GetUiCulture()).Returns("By");
            stubIDateTimeService.Setup(x => x.GetCurrentDate("By")).Returns(DateTime.Now);
            taxService = new TaxService(stubIDateTimeService.Object, stubIUserService.Object);
        }

        [TestMethod]
        public void GetTax_2020_07_19_returned20()
        {
            Assert.AreEqual(0.2m, taxService.GetTax(new DateTime(2020, 07, 19)));
        }

        [TestMethod]
        public void GetTax_2021_07_19_returned20()
        {
            Assert.AreEqual(0.2m, taxService.GetTax(new DateTime(2021, 07, 19)));
        }

        [TestMethod]
        public void GetTax_2019_07_19_returned30()
        {
            Assert.AreEqual(0.3m, taxService.GetTax(new DateTime(2019, 07, 19)));
        }

        [TestMethod]
        public void GetTax_2001_07_19_returned30()
        {
            Assert.AreEqual(0.3m, taxService.GetTax(new DateTime(2001, 07, 19)));
        }

        [TestMethod]
        public void GetTax_2000_07_19_returned15()
        {
            Assert.AreEqual(0.15m, taxService.GetTax(new DateTime(2000, 07, 19)));
        }

        [TestMethod]
        public void GetTax_1999_07_19_returned15()
        {
            Assert.AreEqual(0.15m, taxService.GetTax(new DateTime(1999, 07, 19)));
        }

        [TestMethod]
        public void GetTax_2020_0_0_returnedException()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxService.GetTax(new DateTime(2020, 0, 0)));
        }

        [TestMethod]
        public void GetTax_0_07_0_returnedException()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxService.GetTax(new DateTime(0, 07, 0)));
        }

        [TestMethod]
        public void GetTax_0_0_19_returnedException()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxService.GetTax(new DateTime(0, 0, 19)));
        }

        [TestMethod]
        public void GetTax_minus2020_07_19_returnedException()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxService.GetTax(new DateTime(-2020, 07, 19)));
        }

        [TestMethod]
        public void GetTax_2020_minus7_19_returnedException()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxService.GetTax(new DateTime(2020, -7, 19)));
        }

        [TestMethod]
        public void GetTax_2020_07_minus19_returnedException()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxService.GetTax(new DateTime(2020, 07, -19)));
        }

        [TestMethod]
        public void GetTax_null_returned15()
        {
            Assert.AreEqual(0.15m, taxService.GetTax(new DateTime()));
        }

        [TestMethod]
        public void ApplyTax_2020_1_returned12()
        {
            Assert.AreEqual(1.2m, taxService.ApplyTax(1m));
        }

        [TestMethod]
        public void ApplyTax_2020_minus1_returnedminus12()
        {
            Assert.AreEqual(-1.2m, taxService.ApplyTax(-1m));
        }
    }
}
