using System.Text.Json;
using Students.Models;
using Students;

var json = File.ReadAllText("students.json");
var students = JsonSerializer.Deserialize<List<Student>>(json);

ConsoleHelper.PrintText("+++++++++++++++++++++++");
ConsoleHelper.PrintText("+++ С Т У Д Е Н Т Ы +++");
ConsoleHelper.PrintText("+++    ver 0.1      +++");
ConsoleHelper.PrintText("+++++++++++++++++++++++");

var exit = false;
do
{
    ConsoleHelper.PrintInfo("=== М Е Н Ю ===");
    ConsoleHelper.PrintInfo("= 1. Показать всех студентов");
    ConsoleHelper.PrintInfo("= 2. Найти студента по имени/фамилии");
    ConsoleHelper.PrintInfo("= 0. Выход");
    var input = ConsoleHelper.Input("Введите пункт меню:");

    switch (input)
    {
        case "0": // 0. Выход
            exit = true;
            break;
        case "1": // 1. Показать всех студентов
            foreach (var student in students)
            {
                PrintStudent(student);
            }
            break;
        case "2": // 2. Найти студента по имени/фамилии
            var name = ConsoleHelper.Input("Введите искомое имя/фамилию: ");
            var result = FindStudentsByName(name);
            foreach (var student in students)
            {
                PrintStudent(student);
            }
            break;
        default:
            ConsoleHelper.PrintError("Неправильный ввод!");
            ConsoleHelper.PrintInfo("Повторите ввод");
            break;
    }
} while (!exit);

ConsoleHelper.PrintInfo("До свидания...");

#region Functions

void PrintStudent(Student student)
{
    ConsoleHelper.PrintText($"{student.FullName} ({student.Age}) {student.Faculty}");
    ConsoleHelper.PrintText("Marks:");
    foreach (var mark in student.Marks)
    {
        ConsoleHelper.PrintText($"\t{mark.Data}: {mark.Subject}, {mark.Teacher.FullName}, {mark.Rating}");
    }
    ConsoleHelper.PrintText("--- --- ---");
}

IEnumerable<Student> FindStudentsByName(string name)
{
    /*var result = new List<Student>();
    
    foreach (var student in students)
    {
        if (student.FirstName == name || student.LastName == name)
        {
            result.Add(student);
        }
    }

    return result;*/
    
    foreach (var student in students)
    {
        if (student.FirstName == name || student.LastName == name)
        {
            yield return student;
        }
    }
}

#endregion
