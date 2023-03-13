
string input;
Catalog vehicles = new Catalog();

while ((input = Console.ReadLine()) != "end")
{
    string type = input.Split("/", StringSplitOptions.RemoveEmptyEntries)[0];

    if (type == "Truck")
    {
        vehicles.Trucks.Add(new Truck()
        {
            Brand = input.Split('/')[1],
            Model = input.Split('/')[2],
            Weight = int.Parse(input.Split('/')[3])
        });
    }
    else
    {
        vehicles.Cars.Add(new Car()
        {
            Brand = input.Split('/')[1],
            Model = input.Split('/')[2],
            HorsePower = int.Parse(input.Split('/')[3])
        });
        
    }
}

if (vehicles.Cars.Count > 0)
{
    Console.WriteLine($"Cars:");

    foreach (var vehicle in vehicles.Cars.OrderBy(v => v.Brand))
    {
        Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
    }
}

if (vehicles.Trucks.Count > 0)
{
    Console.WriteLine($"Trucks:");

    foreach (var vehicle in vehicles.Trucks.OrderBy(v => v.Brand))
    {
        Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.Weight}kg");
    }
}
public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

}

public class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

}

