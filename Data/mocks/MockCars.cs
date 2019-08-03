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
                        img = "https://ih1.redbubble.net/image.633811757.1660/mp,840x830,matte,f8f8f8,t-pad,750x1000,f8f8f8.jpg",
                        price = 45_000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car {
                        name = "Nissan Cub",
                        shortDesc = "Piece of shit",
                        longDesc = "Compact piece of god damn shit",
                        img = "https://carimages.com.au/WER0Ij5MxoE-zenTZGQlpcfapTQ=/fit-in/800x540/filters:stretch(FFFFFF)/vehicles/used/2004/NISSAN/CUBE/2004-NISSAN-CUBE-used-1381-113-1.jpg",
                        price = 1_000,
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
