namespace GetSet;
class BankAccount
{
    private int _balance;
    private string _ownerName;

    public int Balance
    {
        get => _balance;
        set
        {
            if (value < 0)
            {
                throw new Exception("Баланс не может быть отрицательным");
            }
            _balance = value;
        }
    }
    public int GetBalance() => Balance;
    public void SetBalance() => Balance = _balance;

    public string OwnerName
    {
        get => _ownerName;
        set
        {
            _ownerName = value;
        }
    }

    public string GetName() => OwnerName;
    public void SetName() => OwnerName = _ownerName;

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
}
