namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Car> cars = new ();
        List<Engine> engines = new ();
        int enginesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < enginesCount; i++)
        {
            string[] engineProperties = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Engine engine = Engine.GetEngineProperties(engineProperties);
            engines.Add(engine);
        }

        int carsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < carsCount; i++)
        {
            string[] carProperties = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = Car.GetCarProperties(carProperties, engines);
            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}
