
int number = int.Parse(Console.ReadLine());
Dictionary<string, List<Employee>> employeesSortedByDepertment = new Dictionary<string, List<Employee>>();
Dictionary<string, List<double>> avgSalary = new Dictionary<string, List<double>>();

for (int i = 0; i < number; i++)
{
    string[] command = Console.ReadLine().Split();

    Employee employee = new Employee(command[0], double.Parse(command[1]), command[2]);

    if (!employeesSortedByDepertment.ContainsKey(command[2]))
    {
        employeesSortedByDepertment.Add(command[2], new List<Employee>());
        avgSalary[command[2]] = new List<double>();
    }
    
    employeesSortedByDepertment[command[2]].Add(employee);
    avgSalary[command[2]].Add(employee.Salary);
}

double avgOfSalaries = 0;
string bestDepartment = "";

foreach (var department in avgSalary)
{
    double currentAvg = department.Value.Average();
    if (currentAvg > avgOfSalaries)
    {
        avgOfSalaries = currentAvg;
        bestDepartment = department.Key;
    }
}

Console.WriteLine($"Highest Average Salary: {bestDepartment}");


foreach (var department in employeesSortedByDepertment.Keys)
{
    if (department == bestDepartment)
    {
        foreach (var employee in employeesSortedByDepertment[department].OrderByDescending(y => y.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
        }
    }
}

public class Employee
{
    public Employee(string? name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string? Name { get; set; }
    public double Salary { get; set; }
    public string? Department { get; set; }

    
}
