using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory iCarsCat)
        {
            _allCars = iallCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Category = "Some new";
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
