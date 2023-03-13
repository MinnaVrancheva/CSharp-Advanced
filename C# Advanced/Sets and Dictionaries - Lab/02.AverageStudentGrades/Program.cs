using System;
using System.Collections.Generic;
using System.Linq;

int numberOfStudents = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

for (int i = 0; i < numberOfStudents; i++)
{
    string[] input = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string studentName = input[0];
    decimal studentGrade = decimal.Parse(input[1]);

    if (!studentsGrades.ContainsKey(studentName))
    {
        studentsGrades[studentName] = new List<decimal>();
    }
    studentsGrades[studentName].Add(studentGrade);
}

foreach (var studentName in studentsGrades)
{
    Console.WriteLine($"{studentName.Key} -> {string.Join(' ', studentName.Value.Select(x => $"{x:f2}"))} (avg: {studentName.Value.Average():f2})");
}