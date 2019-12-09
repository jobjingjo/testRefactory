using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;
using WebApplication.Services.Data;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly DefaultContext _context;
        private readonly IDataProvider _dataProvider;

        public ManufacturerService(DefaultContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dataProvider =new DataProvider();
        }

        public string GetManufacturerByModel(string model)
        {
            //https://stackoverflow.com/questions/53945596/entity-framework-core-seed-data
            //https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext
            var foundModel = _context.VehicleModels.FirstOrDefault(x => string.Equals(x.ModelName, model));
            if (foundModel != null)
            {
                var manufacturer = _context.Manufacturers.FirstOrDefault(x => x.Id == foundModel.ManufacturerId);
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