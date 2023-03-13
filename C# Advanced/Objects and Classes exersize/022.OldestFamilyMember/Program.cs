
int count = int.Parse(Console.ReadLine());
Family family = new Family();

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person person = new Person();
    person.Name = input[0];
    person.Age = int.Parse(input[1]);

    family.AddMember(person);
}

Person oldest = family.GetOldestMemebr();
Console.WriteLine($"{oldest.Name} {oldest.Age}");
public class Family
{
    private List<Person> persons;

    public Family()
    {
        this.persons = new();
    }

    public List<Person> Persons { get { return this.persons; } set { this.persons = value; } }

    public void AddMember(Person member)
    {
        this.Persons.Add(member);

    }

    public Person GetOldestMemebr()
    {
        return this.Persons.MaxBy(x => x.Age);
    }
}

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

