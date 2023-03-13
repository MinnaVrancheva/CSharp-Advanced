namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        Dictionary<string, Car> carsByModel = new Dictionary<string, Car>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new()
            {
                Model = carProperties[0],
                FuelAmount = double.Parse(carProperties[1]),
                FuelConsumptionPerKm = double.Parse(carProperties[2]),
            };

            carsByModel.Add(car.Model, car);
        }

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string model = command.Split()[1];
            int distance = int.Parse(command.Split()[2]);

            Car car = carsByModel[model];
            car.Drive(distance);
        }

        foreach (var car in carsByModel.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
        }
    }
}
