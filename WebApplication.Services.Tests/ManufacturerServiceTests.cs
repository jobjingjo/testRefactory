using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;
using WebApplication.Services.Data;

namespace WebApplication.Services.Tests
{
    [TestFixture]
    public class ManufacturerServiceTests
    {
        private DefaultContext _context;
        private IManufacturerService _manufacturerService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<DefaultContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            _context = new DefaultContext(options);
            _context.Database.EnsureCreated();
            var _dataProvider = new DataProvider(_context);
            _manufacturerService = new ManufacturerService(_dataProvider);
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
