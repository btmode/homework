namespace GetSet;
public class StudentsTask
{
    public static void Start()
    {
        var studentsClass = new Students();
        //studentsClass.Marks = studentsClass.FillList();
        studentsClass.FillList();

        var categoryMarks = new Students();
        //Console.WriteLine($"Минимальная оценка: {categoryMarks.MinMark}");
        //Console.WriteLine($"Максимальная оценка: {categoryMarks.MaxMark}");
    }
}

//нужно написать класс, который хранит оценки всех учеников в виде массива чисел.
//Нужно создать два свойства MinMark и MaxMark, внутри которых находятся минимальная и максимальные оценки

public class Students
{
    public List<int> Marks;
    private int _minMark { get; }
    private int _maxMark { get; }

    public void FillList()
    {
        var rnd = new Random();
        var marks = new List<int>();

        while (true)
        {
            Console.Write("Длина листа: ");

            if (int.TryParse(Console.ReadLine(), out var length) && length > 0)
            {

                for (var i = 0; i < length; i++)
                {
                    marks.Add(rnd.Next(2, 6));
                }
                Console.WriteLine("Список оценок: " + string.Join(", ", marks));
                break;
            }

            else { Console.Write("Некорректный ввод,введите цифру больше 1" + Environment.NewLine); }
        }

        Marks = marks;
    }

}



