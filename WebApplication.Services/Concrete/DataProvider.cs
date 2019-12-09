using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Services.Abstract;
using WebApplication.Services.Data;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class DataProvider: IDataProvider
    {
        private readonly DefaultContext _context;

        public DataProvider(DefaultContext context) {
            _context = context ?? throw new System.ArgumentNullException(nameof(context));
        }

        public Manufacturer FindManufacturerById(Guid manufacturerId)
        {
            var manufacturer = _context.Manufacturers.FirstOrDefault(x => x.Id == manufacturerId);
            return manufacturer;
        }

        public VehicleModel FindModelByName(string model)
        {
            var foundModel = _context.VehicleModels.FirstOrDefault(x => string.Equals(x.ModelName, model));
            return foundModel;
        }

        public IList<Manufacturer> GetAllManufacturers()
        {
            return _context.Manufacturers.ToList();
        }
    }
}
