namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<List<int>> tiresYears = new();
            List<List<double>> tiresPressure = new();
                        
            string input;

            Tire tire = new Tire();
            Engine engine = new Engine();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] command = input.Split();

                List<int> listedYears = tire.GetYearInfo(command);
                List<double> listedPressures = tire.GetPressureInfo(command);

                tiresYears.Add(listedYears);
                tiresPressure.Add(listedPressures);
            }

            List<int> horsePowers = new();
            List<double> cubicCapacities = new();
            string input2;

            while((input2  = Console.ReadLine()) != "Engines done")
            {
                string[] command = input2.Split();

                horsePowers.Add(engine.GetHorsePower(command));
                cubicCapacities.Add(engine.GetCubicCapacity(command));
            }

            List<Car> listCars = new List<Car>();
            string input3;

            while ((input3 = Console.ReadLine()) != "Show special")
            {
                string make = input3.Split()[0];
                string model = input3.Split()[1];
                int year = int.Parse(input3.Split()[2]);
                double fuelQuantity = double.Parse(input3.Split()[3]);
                double fuelConsumption = double.Parse(input3.Split()[4]);
                int engineIndex = int.Parse(input3.Split()[5]);
                int tiresIndex = int.Parse(input3.Split()[6]);

                int horsePower = horsePowers[engineIndex];
                double pressure = tire.GetTiresPressure(tiresPressure, tiresIndex);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineIndex, tiresIndex, horsePower, pressure);
                listCars.Add(car);
            }

            if (listCars.Any())
            {
                foreach (var car in listCars)
                {
                    if (car.Year >= 2017 && car.HorsePower > 330 && car.pressure > 9 && car.pressure < 10)
                    {
                        car.FuelQuantity = car.Drive(car.FuelQuantity, car.FuelConsumption);
                        Console.WriteLine($"Make: {car.Make}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Year: {car.Year}");
                        Console.WriteLine($"HorsePowers: {car.HorsePower}");
                        Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                    }
                }
            }
        }
    }
}
