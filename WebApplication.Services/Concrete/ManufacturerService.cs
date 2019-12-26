using System;
using System.Collections.Generic;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IDataProvider _dataProvider;

        public ManufacturerService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
        }

        public string GetManufacturerByModel(string model)
        {
            var foundModel = _dataProvider.FindModelByName(model);
            if (foundModel != null)
            {
                return string.Empty;
            }

            var manufacturer = _dataProvider.FindManufacturerById(foundModel.ManufacturerId);

            if (manufacturer != null)
            {
                return manufacturer.ManufacturerName;
            }

            return string.Empty;
        }

        public IList<Manufacturer> GetAll()
        {
            return _dataProvider.GetAllManufacturers();
        }
    }
}