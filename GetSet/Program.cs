namespace GetSet;
class Program
{
    static void Main()
    {

        Test.Start();
        var account = new BankAccount();
        account.SetBalance(-100);
    }
}
