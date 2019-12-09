using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;
using WebApplication.Services.Data;
using WebApplication.Services.Models;

namespace WebApplication.Services.Tests
{
    [TestFixture]
    public class DataProviderTests
    {
        private DefaultContext _context;
        private Manufacturer _manufacturer1;
        private Manufacturer _manufacturer2;
        private List<Manufacturer> _manufacturers;
        private IDataProvider _dataProvider;
        private VehicleModel _vehicleModel1;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<DefaultContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            _context = new DefaultContext(options);


            _manufacturer1 = new Manufacturer()
            {
                Id = Guid.NewGuid(),
                ManufacturerName = "Mock1"
            };
            _manufacturer2 = new Manufacturer()
            {
                Id = Guid.NewGuid(),
                ManufacturerName = "Mock2"
            };
            _manufacturers = new List<Manufacturer>()
              {
                _manufacturer1,
                _manufacturer2
              };

            _vehicleModel1 = new VehicleModel()
            {
                Id = Guid.NewGuid(),
                ManufacturerId = _manufacturer1.Id,
                ModelName = "MockModel1"
            };
            var vehicleModels = new List<VehicleModel>()
              {
                _vehicleModel1
              };
            _context.Manufacturers = CreateDbSetMock(_manufacturers).Object;
            _context.VehicleModels = CreateDbSetMock(vehicleModels).Object;

            _dataProvider = new DataProvider(_context);
        }

        [TestCase]
        public void FindManufacturerById_WhenFound_ShouldReturnManufacturer()
        {
            //Act
            var result = _dataProvider.FindManufacturerById(_manufacturer1.Id);

            //Assert
            Assert.AreEqual(_manufacturer1, _manufacturer1);
        }

        [TestCase]
        public void FindManufacturerById_WhenNotFound_ShouldReturnNull()
        {
            //Act
            var result = _dataProvider.FindManufacturerById(Guid.NewGuid());

            //Assert
            Assert.IsNull(result);
        }

        [TestCase]
        public void FindModelByName_WhenFound_ShouldReturnVehicleModel()
        {
            //Act
            var result = _dataProvider.FindModelByName(_vehicleModel1.ModelName);

            //Assert
            Assert.AreEqual(_vehicleModel1, result);
        }

        [TestCase]
        public void FindModelByName_WhenNotFound_ShouldReturnNull()
        {
            //Act
            var result = _dataProvider.FindModelByName("notExists");

            //Assert
            Assert.IsNull(result);
        }

        [TestCase]
        public void GetAllManufacturers()
        {
            //Act
            var result = _dataProvider.GetAllManufacturers();

            //Assert
            CollectionAssert.AreEquivalent(_manufacturers, result);
        }

        private static Mock<DbSet<T>> CreateDbSetMock<T>(IEnumerable<T> elements) where T : class
        {
            var elementsAsQueryable = elements.AsQueryable();
            var dbSetMock = new Mock<DbSet<T>>();

            dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(elementsAsQueryable.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(elementsAsQueryable.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(elementsAsQueryable.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(elementsAsQueryable.GetEnumerator());

            return dbSetMock;
        }
    }
}
