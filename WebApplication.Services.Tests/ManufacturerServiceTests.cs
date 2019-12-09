using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;
using WebApplication.Services.Data;

namespace WebApplication.Services.Tests
{
    [TestFixture]
    public class ManufacturerServiceTests
    {

        private IManufacturerService _manufacturerService;

        [SetUp]
        public void Setup()
        {
            //http://web.archive.org/web/20150404154203/https://www.remondo.net/repository-pattern-example-csharp/
            var options = new DbContextOptionsBuilder<DefaultContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            _manufacturerService = new ManufacturerService(new DefaultContext(options));
        }

        [TestCase("488GTB", "FERRARI")]
        [TestCase("A8ハイブリッド", "AUDI")]
        [TestCase("エテルナ", "MITSUBISHI")]
        [TestCase("スプリンタートレノ", "TOYOTA")]
        [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
        public void CanIdentifyManufacturer(string value, string expected)
        {
            //Act
            var result = _manufacturerService.GetManufacturerByModel(value);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
