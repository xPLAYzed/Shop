using Shop.Data.Interfaces;
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
                    new Car 
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый электрокар",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "https://auto.ironhorse.ru/wp-content/uploads/2016/01/Model-S.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                     new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://i0.carsie.ie/NzYxMDBkY2JkZjNkOTZhMDM2NDNhYmYzMWI1NjAwOTSTEz22MN3Fug32dVxWbnKMMjQ0NTAxMC02NDAyMjg1Ni5qcGd8fHx8fHx8fHx8fDY0MHg0ODA=.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                      new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-verba/216201/2a00000174bf5841ab75a58092ff2a351603/cattouchret",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                       new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный амтомобиль для городской жизни",
                        img = "https://www.mercedes-benz.ru/passengercars/mercedes-benz-cars/models/c-class/saloon-w205/design/exterior/_jcr_content/contentgallerycontainer/par/contentgallery_ff4b/par/contentgallerytile_7/image.MQ4.8.20190705112058.jpeg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                       new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный амтомобиль для городской жизни",
                        img = "https://ev-database.org/img/auto/Nissan_Leaf_2018/Nissan_Leaf_2018-01@2x.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                };
            }
        }



        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
