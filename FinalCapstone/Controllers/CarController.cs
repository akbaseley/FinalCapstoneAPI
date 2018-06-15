using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinalCapstone.Models;

namespace FinalCapstone.Controllers
{
    public class CarController : ApiController
    {
        [HttpGet]
        public List<Car> GetAllCars()
        {
            //lists all cars in the Database
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.ToList();
        }

        [HttpGet]
        public List<Car> GetCarsByMake(string make)
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Where(c => c.Make.Contains(make)).ToList();
        }

        [HttpGet]
        public List<Car> GetCarsByModel(string model)
        {
            //lists all cars of a certain model
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Where(c => c.Model.Contains(model)).ToList();
        }

        [HttpGet]
        public List<Car> GetCarsByColor(string color)
        {
            //lists all cars of a certain color
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Where(c => c.Color.Contains(color)).ToList();
        }

        [HttpGet]
        public List<Car> GetCarsByYear(string year)
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Where(c => c.Year.Contains(year)).ToList();
        }

        [HttpGet]
        public List<Car> GetCarsbyMakeandModel(string make, string model)
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            List<Car> CarsbyMake = ORM.Cars.Where(c => c.Make.Contains(make)).ToList();
            return CarsbyMake.Where(c => c.Model.Contains(model)).ToList();
        }

        [HttpGet]
        public List<Car> GetCarsByColorandYear(string color, string year)
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            List<Car> CarsbyColor = ORM.Cars.Where(c => c.Color.Contains(color)).ToList();
            return CarsbyColor.Where(c => c.Year.Contains(year)).ToList();
        }

        [HttpGet]
        public List<Car> GetCarInformation(string make, string model, string color, string year)
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            List<Car> CarsbyMake = ORM.Cars.Where(c => c.Make.Contains(make)).ToList();
            List<Car> CarsbyMakeAndModel = CarsbyMake.Where(c => c.Model.Contains(model)).ToList();
            List<Car> CarsbyMakeAndModelAndColor = CarsbyMakeAndModel.Where(c => c.Color.Contains(color)).ToList();
            return CarsbyMakeAndModelAndColor.Where(c => c.Year.Contains(year)).ToList();
        }

        [HttpGet]
        public List<string> ListofMakes()
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Select(c => c.Make).Distinct().ToList();
        }

        [HttpGet]
        public List<string> ListofModels()
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Select(c => c.Model).Distinct().ToList();
        }

        [HttpGet]
        public List<string> ListofColors()
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Select(c => c.Color).Distinct().ToList();
        }

        [HttpGet]
        public List<string> ListofYears()
        {
            GCCarsDBEntities ORM = new GCCarsDBEntities();
            return ORM.Cars.Select(c => c.Year).Distinct().ToList();
        }
    }
}
