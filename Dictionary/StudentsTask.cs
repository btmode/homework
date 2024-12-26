using System.Collections;
using System.Collections.Generic;

namespace Dictionary;
public class StudentsTask
{
    public void Start()
    {
        Students[] students = [
            new Students{Name ="Arina" , Age = 99},
            new Students{Name ="John" , Age = 20},
            new Students{Name ="Alice" , Age = 22},
            new Students{Name ="Bob" , Age = 29},
            new Students{Name ="Eve" , Age = 21},
            new Students{Name ="Charli" , Age = 20},
            new Students{Name ="Dave" , Age = 21},
            new Students{Name ="Dima" , Age = 4},
            new Students{Name ="Roma" , Age = 63},
            new Students{Name ="Jon" , Age = 43},
            new Students{Name ="Sultan" , Age = 11},
            new Students{Name ="Suliman" , Age = 1},

            ];

        var student = new Students();
        student._dictionary = student.GroupByAge(students);
    }
}

class Students
{
    public Dictionary<string, int> _dictionary { get; set; } = new Dictionary<string, int>();
    public string Name { get; set; }
    public int Age { get; set; }

    public Dictionary<string, int> GroupByAge(Students[] students)
    {

        for (var i = 0; i < students.Length; i++)
        {
            for (var j = i + 1; j < students.Length; j++)
            {
                if (students[i].Age > students[j].Age)
                {
                    var temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        var studentsSort = new List<Students>(students);
        _dictionary = PrintAllStudent(studentsSort);

        return _dictionary;
    }
    public Dictionary<string, int> PrintAllStudent(List<Students> studentsSort)
    {
        var dictionary = new Dictionary<string, int>();

        Console.Write("Все ученики по возрастанию\n");

        var count = 0;
        foreach (var student in studentsSort)
        {
            count++;
            Console.Write($"{count}) Ученик - Имя: {student.Name}, Возраст: {student.Age}" + Environment.NewLine);
            dictionary[student.Name] = student.Age;
        }
        return dictionary;
    }
}

