using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IDataProvider _dataProvider;

        public ManufacturerService()
        {
            _dataProvider =new DataProvider();
        }

        public string GetManufacturerByModel(string model)
        {
            var foundModel = _dataProvider.Models.FirstOrDefault(x => string.Equals(x.ModelName, model));
            if (foundModel != null)
            {
                var manufacturer = _dataProvider.Manufacturers.FirstOrDefault(x => x.Id == foundModel.ManufacturerId);
                if (manufacturer != null)
                    return manufacturer.ManufacturerName;
            }

            return string.Empty;
        }

        public IList<Manufacturer> GetAll()
        {
            return _dataProvider.Manufacturers.ToList();
        }
    }
}