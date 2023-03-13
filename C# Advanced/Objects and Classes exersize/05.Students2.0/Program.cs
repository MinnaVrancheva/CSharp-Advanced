
List<Student> students = new List<Student>();
string command;

while ((command = Console.ReadLine()) != "end")
{
    
    string firstName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
    string lastName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
    int age = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
    string homeTown = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3];

    Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

    if (student == null)
    {
        students.Add(new Student()
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = homeTown
        });
    }
    else
    {
        student.FirstName = firstName;
        student.LastName = lastName;
        student.Age = age;
        student.HomeTown = homeTown;
    }
}

string command2 = Console.ReadLine();

foreach (Student student in students)
{
    if (student.HomeTown == command2)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}

//static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
//{
//    foreach (Student student in students)
//    {
//        if (student.FirstName == firstName && student.LastName == lastName)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//static Student GetStudent(List<Student> students, string firstName, string lastName)
//{
//    Student existingStudent = null;
//    foreach (Student student in students)
//    {
//        if (student.FirstName == firstName && student.LastName == lastName)
//        {
//            existingStudent = student;
//        }
//    }

//    return existingStudent;
//}

public class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? HomeTown { get; set; }
}


