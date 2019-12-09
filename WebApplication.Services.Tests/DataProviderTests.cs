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
    public class DataProviderTests
    {
        private DefaultContext _context;
        private IDataProvider _dataProvider;

        [SetUp]
        public void Setup()
        {           
            var options = new DbContextOptionsBuilder<DefaultContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            _context = new DefaultContext(options);
            _context.Database.EnsureCreated();
            _dataProvider = new DataProvider(_context);
        }

        [TestCase("488GTB", "FERRARI")]
        [TestCase("A8ハイブリッド", "AUDI")]
        [TestCase("エテルナ", "MITSUBISHI")]
        [TestCase("スプリンタートレノ", "TOYOTA")]
        [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
        public void FindManufacturerById(Guid value, string expected)
        {
            //Act
            var result = _dataProvider.FindManufacturerById(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("488GTB", "FERRARI")]
        [TestCase("A8ハイブリッド", "AUDI")]
        [TestCase("エテルナ", "MITSUBISHI")]
        [TestCase("スプリンタートレノ", "TOYOTA")]
        [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
        public void FindModelByName(Guid value, string expected)
        {
            //Act
            var result = _dataProvider.FindManufacturerById(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("488GTB", "FERRARI")]
        [TestCase("A8ハイブリッド", "AUDI")]
        [TestCase("エテルナ", "MITSUBISHI")]
        [TestCase("スプリンタートレノ", "TOYOTA")]
        [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
        public void GetAllManufacturers(Guid value, string expected)
        {
            //Act
            var result = _dataProvider.GetAllManufacturers();

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
