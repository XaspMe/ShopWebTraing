using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla",
                        shortDesc = "ElonMusk",
                        longDesc = "Elon musk best car",
                        img = "/img/tesla.jpg",
                        price = 45_000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car {
                        name = "Nissan Cube",
                        shortDesc = "Good car for big family",
                        longDesc = "Compact, cheep, roomy car",
                        img = "/img/cube.jpg",
                        price = 1_000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                    new Car {
                        name = "Porsche 918 Spyder",
                        shortDesc = "Stylish and bright",
                        longDesc = "For confident riders",
                        img = "/img/porsche.jpg",
                        price = 57_000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Car> FavCars { get; set; }

        public Car ObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
