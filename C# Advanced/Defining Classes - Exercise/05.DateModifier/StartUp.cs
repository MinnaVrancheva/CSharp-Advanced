namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();

        int differenceInDays = DateModifier.GetDifferenceBetweenTwoDates(startDate, endDate);

        Console.WriteLine(differenceInDays);
    }
}
