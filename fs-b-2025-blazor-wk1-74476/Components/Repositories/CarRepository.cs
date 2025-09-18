public static class CarRepository
{
    public static List<Car> GetCars()
    {
        return new List<Car>
        {
            new Car { Id = 1, Model = "Mustang", Brand = "Ford", Year = 2020, Type = "Sports", Rating = 8.7 },
            new Car { Id = 2, Model = "Civic", Brand = "Honda", Year = 2019, Type = "Sedan", Rating = 8.2 },
            new Car { Id = 3, Model = "Model S", Brand = "Tesla", Year = 2021, Type = "Electric", Rating = 9.1 },
            new Car { Id = 4, Model = "Corolla", Brand = "Toyota", Year = 2018, Type = "Sedan", Rating = 7.9 },
            new Car { Id = 5, Model = "Wrangler", Brand = "Jeep", Year = 2022, Type = "SUV", Rating = 8.5 }
        };
    }
}
