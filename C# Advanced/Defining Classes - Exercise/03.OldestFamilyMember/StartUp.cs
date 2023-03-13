namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        Family family = new Family();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string name = input.Split()[0];
            int age = int.Parse(input.Split()[1]);

            Person person = new(name, age);
            family.AddMember(person);
        }

        Person oldest = family.GetOldestMember();
        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}

