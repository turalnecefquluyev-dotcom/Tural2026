using LinqTest.Entities;

namespace LinqTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Model = "BMW M5",
                    Year = 2026,
                    Price = 150000,
                    Color = "Black",
                    IsNew = true
                },

                new Car
                {
                    Id = 2,
                    Model = "Mercedes C63",
                    Year = 2025,
                    Price = 120000,
                    Color = "White",
                    IsNew = true
                },

                new Car
                {
                    Id = 3,
                    Model = "Toyota Camry",
                    Year = 2022,
                    Price = 45000,
                    Color = "Gray",
                    IsNew = false
                },

                new Car
                {
                    Id = 4,
                    Model = "BMW X5",
                    Year = 2024,
                    Price = 90000,
                    Color = "Black",
                    IsNew = false
                },

                new Car
                {
                    Id = 5,
                    Model = "Toyota Corolla",
                    Year = 2026,
                    Price = 35000,
                    Color = "White",
                    IsNew = true
                }
            };


            

            Car newCar = new Car
            {
                Id = 6,
                Model = "Mercedes E63",
                Year = 2026,
                Price = 130000,
                Color = "Black",
                IsNew = true
            };

            cars.Add(newCar);

            Console.WriteLine("Yeni avtomobil əlavə edildi.");


            

            Console.WriteLine("\nBütün avtomobillər:");

            foreach (var car in cars)
            {
                Console.WriteLine(
                    $"Id: {car.Id}, Model: {car.Model}, Year: {car.Year}, Price: {car.Price}, Color: {car.Color}, New: {car.IsNew}"
                );
            }


            

            var updateCar = cars.FirstOrDefault(x => x.Id == 1);

            if (updateCar != null)
            {
                updateCar.Price = 155000;
                updateCar.Color = "Red";
            }

            Console.WriteLine("\nAvtomobil yeniləndi.");


          
           

            var deleteCar = cars.FirstOrDefault(x => x.Id == 6);

            if (deleteCar != null)
            {
                cars.Remove(deleteCar);
            }

            Console.WriteLine("Avtomobil silindi.");


          

            var expensiveCars = cars
                .Where(x => x.Price > 50000)
                .ToList();

            Console.WriteLine("\n50000-dən bahalı avtomobillər:");

            foreach (var car in expensiveCars)
            {
                Console.WriteLine($"{car.Model} - {car.Price}");
            }


            

            string search = "BMW";

            var searchResult = cars
                .Where(x => x.Model.Contains(search))
                .ToList();

            Console.WriteLine("\nBMW avtomobilləri:");

            foreach (var car in searchResult)
            {
                Console.WriteLine($"{car.Model} - {car.Price}");
            }


          

            var newCars = cars
                .Where(x => x.IsNew == true)
                .ToList();

            Console.WriteLine("\nYeni avtomobillər:");

            foreach (var car in newCars)
            {
                Console.WriteLine($"{car.Model} - {car.Year}");
            }


          

            var groups = cars
                .GroupBy(x => x.Model.Split(' ')[0]);

            Console.WriteLine("\nMarkalara görə qruplaşdırma:");

            foreach (var group in groups)
            {
                Console.WriteLine($"\nMarka: {group.Key}");

                foreach (var car in group)
                {
                    Console.WriteLine($"  {car.Model} - {car.Price}");
                }
            }


            Console.ReadKey();
        }
    }
}