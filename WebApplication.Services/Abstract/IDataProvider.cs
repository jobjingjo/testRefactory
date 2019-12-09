using System;
using System.Collections.Generic;
using WebApplication.Services.Models;

namespace WebApplication.Services.Abstract
{
    public interface IDataProvider
    {
        VehicleModel FindModelByName(string model);
        Manufacturer FindManufacturerById(Guid manufacturerId);
        IList<Manufacturer> GetAllManufacturers();
    }
}