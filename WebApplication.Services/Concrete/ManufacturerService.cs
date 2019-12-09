using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;

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
                var manufaturer = _dataProvider.Manufacturers.FirstOrDefault(x => x.Id == foundModel.ManufacturerId);
                if (manufaturer != null)
                    return manufaturer.ManufacturerName;
            }

            return string.Empty;
        }
    }
}