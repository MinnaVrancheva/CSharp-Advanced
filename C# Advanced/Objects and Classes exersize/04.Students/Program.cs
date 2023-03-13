
List<Student> students = new List<Student>();
string command;

while ((command = Console.ReadLine()) != "end")
{
    Student student = new Student();
    student.FirstName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
    student.LastName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
    student.Age = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
    student.HomeTown = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3];

    students.Add(student);
}

string command2 = Console.ReadLine();

foreach (Student student in students)
{
    if (student.HomeTown == command2)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}
public class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? HomeTown { get; set; }

}

