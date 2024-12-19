namespace GetSet;
public class Students
{
    public static void Start()
    {
        var studentMarks = new StudentMarks();
        List<CategoryMarks> _marks = studentMarks.FillList();       
        studentMarks.Mark = _marks;

        var categoryMarks = new CategoryMarks();
        Console.WriteLine($"Минимальная оценка: {categoryMarks.MinMark}");
        Console.WriteLine($"Максимальная оценка: {categoryMarks.MaxMark}");



    }
}

class StudentMarks
{


    public List<CategoryMarks> _marks;
    public List<CategoryMarks> Mark
    {
        get => _marks;
        set
        {
            _marks = value;
        }
    }
    public List<CategoryMarks> FillList()
    {
        Random rnd = new Random();
        var marks = new List<CategoryMarks>();

        while (true)
        {
            Console.Write("Длинна листа: ");
            if (int.TryParse(Console.ReadLine(), out var length) && length > 0)
            {

                for (var i = 0; i < length; i++)
                {
                   marks.Add(rnd.Next(2, 6));
                }
                Console.WriteLine("Список оценок: " + string.Join(", ", marks));
                break;
            }

            else { Console.Write("Некоректный ввод,введите цифру больше 1" + Environment.NewLine); }
        }
        return marks;
    }
}

public class CategoryMarks
{
    private int _minMark {  get; set; }
    private int _maxMark { get; set; }

}



