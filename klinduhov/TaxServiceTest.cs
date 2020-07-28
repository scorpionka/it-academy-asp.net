using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestApp;
using UnitTestApp.Controllers;
using Moq;
using ItAcademy.HomeWork.NumberOne;
using System.Globalization;

namespace UnitTestApp.Tests
{
    [TestClass]
    public partial class TaxServiceTest
    {
        [TestMethod]
        public void GetTaxMethodReturn20Percent()
        {
            // Arrange
            var mockIUserService = new Mock<IUserService>();
            mockIUserService.Setup(a => a.GetUiCulture()).Returns(CultureInfo.CurrentCulture.Name);

            var mockDateTimeService = new Mock<IDateTimeService>();
            mockDateTimeService.Setup(a => a.GetCurrentDate(CultureInfo.CurrentCulture.Name)).Returns(DateTime.Now);
            
            TaxService taxService = new TaxService(mockDateTimeService.Object, mockIUserService.Object);

            DateTime date = new DateTime(2021, 01, 01);

            // Act
            decimal tax = taxService.GetTax(date);

            // Assert
            Assert.AreEqual(0.2M, tax);
        }

        [TestMethod]
        public void GetTaxMethodReturn30Percent()
        {
            // Arrange
            var mockIUserService = new Mock<IUserService>();
            mockIUserService.Setup(a => a.GetUiCulture()).Returns(CultureInfo.CurrentCulture.Name);

            var mockDateTimeService = new Mock<IDateTimeService>();
            mockDateTimeService.Setup(a => a.GetCurrentDate(CultureInfo.CurrentCulture.Name)).Returns(DateTime.Now);

            TaxService taxService = new TaxService(mockDateTimeService.Object, mockIUserService.Object);

            DateTime date = new DateTime(2001, 01, 01);

            // Act
            decimal tax = taxService.GetTax(date);

            // Assert
            Assert.AreEqual(0.3M, tax);
        }


        [TestMethod]
        public void GetTaxMethodReturn15Percent()
        {
            // Arrange
            var mockIUserService = new Mock<IUserService>();
            mockIUserService.Setup(a => a.GetUiCulture()).Returns(CultureInfo.CurrentCulture.Name);

            var mockDateTimeService = new Mock<IDateTimeService>();
            mockDateTimeService.Setup(a => a.GetCurrentDate(CultureInfo.CurrentCulture.Name)).Returns(DateTime.Now);

            TaxService taxService = new TaxService(mockDateTimeService.Object, mockIUserService.Object);

            DateTime date = new DateTime(1998, 01, 01);

            // Act
            decimal tax = taxService.GetTax(date);

            // Assert
            Assert.AreEqual(0.15M, tax);
        }

        [TestMethod]
        public void ApplyTaxMethodReturnOneDotTwo()
        {
            // Arrange
            DateTime date = new DateTime(2021, 01, 01);
            var mockIUserService = new Mock<IUserService>();
            mockIUserService.Setup(a => a.GetUiCulture()).Returns(CultureInfo.CurrentCulture.Name);

            var mockDateTimeService = new Mock<IDateTimeService>();
            mockDateTimeService.Setup(a => a.GetCurrentDate(CultureInfo.CurrentCulture.Name)).Returns(date);

            TaxService taxService = new TaxService(mockDateTimeService.Object, mockIUserService.Object);
                                    
            // Act
            decimal tax = taxService.ApplyTax(1M);

            // Assert
            Assert.AreEqual(1.2M, tax);
        }

        [TestMethod]
        public void ApplyTaxMethodReturnOneDotThree()
        {
            // Arrange
            DateTime date = new DateTime(2019, 01, 01);
            var mockIUserService = new Mock<IUserService>();
            mockIUserService.Setup(a => a.GetUiCulture()).Returns(CultureInfo.CurrentCulture.Name);

            var mockDateTimeService = new Mock<IDateTimeService>();
            mockDateTimeService.Setup(a => a.GetCurrentDate(CultureInfo.CurrentCulture.Name)).Returns(date);

            TaxService taxService = new TaxService(mockDateTimeService.Object, mockIUserService.Object);

            // Act
            decimal tax = taxService.ApplyTax(1M);

            // Assert
            Assert.AreEqual(1.3M, tax);
        }

    }
}
