namespace Dictionary;

class Program
{
    private string text { get; set; }

    public string Text
    {

    }
    public static void Main()
    {
        //var setValueTask = new SetValueTask();
        //setValueTask.Start();
        var studentstask = new StudentsTask();
        studentstask.Start();
        //var deletKey = new DeletKeyTask();
        //deletKey.Start();
    }

}

