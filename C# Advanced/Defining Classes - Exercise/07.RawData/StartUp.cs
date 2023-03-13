namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new(
                input[0],
                int.Parse(input[1]),
                int.Parse(input[2]),
                int.Parse(input[3]),
                input[4],
                double.Parse(input[5]),
                int.Parse(input[6]),
                double.Parse(input[7]),
                int.Parse(input[8]),
                double.Parse(input[9]),
                int.Parse(input[10]),
                double.Parse(input[11]),
                int.Parse(input[12])
            );

            cars.Add(car);
        }

        string[] carsFilteredByTirePressure;
        string input2 = Console.ReadLine();

        if (input2 == "fragile")
        {
            carsFilteredByTirePressure = cars.Where(t => t.Cargo.Type == "fragile" && t.Tires.Any(p => p.Pressure < 1))
                .Select(cars => cars.Model)
                .ToArray();
        }
        else
        {
            carsFilteredByTirePressure = cars
                .Where(t => t.Cargo.Type == "flammable" && t.Engine.Power > 250)
                .Select(t => t.Model)
                .ToArray();
        }
        Console.WriteLine(String.Join(Environment.NewLine, carsFilteredByTirePressure));
    }
}
