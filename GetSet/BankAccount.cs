namespace GetSet;
class BankAccount
{
    private int _balance;
    private string _ownerName;
    private DateTime _date;

    public int MyProperty
    {
        get => _date;
        set => _date = value;
    }

    // Свойство = приватное поле + гет и сет
    public int Balance
    {
        get => _balance;
        set
        {
            if (value < 0)
                throw new Exception("Баланс не может быть отрицательным");
            _balance = value;
        }
    }

    //public int GetBalance() => _balance;
    //public void SetBalance(int n)
    //{
    //    if (n < 0)
    //        throw new Exception("Баланс не может быть отрицательным");
    //    _balance = n;
    //}

    public string OwnerName
    {
        get => _ownerName;
        set
        {
            _ownerName = value;
        }
    }

    //public string GetName() => OwnerName;
    //public void SetName() => OwnerName = _ownerName;
}

public class Test
{
    public static void Start()
    {

        var BankAccount = new BankAccount();
        try
        {
            BankAccount.Balance = 100;
            BankAccount.OwnerName = "Диман";

            Console.Write($"Ваш баланс: {BankAccount.Balance}\n");
            Console.Write($"Имя владельца: {BankAccount.OwnerName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

    }
}
