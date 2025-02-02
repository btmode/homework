using System.Collections;
using System.Collections.Generic;

namespace Dictionary;
public class StudentsTask
{
    public void Start()
    {
        // var
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

        foreach (var student in _dictionaty)
        {

        }
    }
}
public class Students
{
    public string Name { get; set; }
    public int Age { get; set; }
}
// Разделить на два класса: Student - Name, age, StudentHelper.GroupByAge(new List<Students>())
public class StudentHelper
{
    public Dictionary<int, Students[]> _dictionary { get; set; } = [];


    public Dictionary<int, Students[]> GroupByAge(Students[] students)
    {
        var studentsSort = new Dictionary<int, Students[]>();

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
        studentsSort = students.();
        return studentsSort;
    }

}



