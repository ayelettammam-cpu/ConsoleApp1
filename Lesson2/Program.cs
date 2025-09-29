using Lesson2;

internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("enter  account number");
            int acountNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter initial amount");
            int amount = int.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(acountNumber,amount);

        }
        catch (FormatException ex)
        {
            System.Console.WriteLine("Input wasnt in a corrent format" + ex.Message);

        }
        catch (Exception ex)
        {
            
        }
    }
}

internal class BankAccount
{
    public int AccountId { get; init; }
    public int Balance { get; private set; }

    public BankAccount(int AccountId, int initialBalance)
    {
        if (AccountId <= 0)
        {
            throw new ArgumentOutOfRangeException("Initial balance cannot be nagitive");
        }
        this.AccountId = AccountId;
        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException("Initial balance cannot be nagitive");
        }
        
        this.Balance = initialBalance;
    }

    public OperationResult Withdraws(int x)
    {
        if (x < 0)
        {
                        throw new ArgumentOutOfRangeException("Initial balance cannot be nagitive");
        }
        if (Balance < x)
        {
            return OperationResult.failure("Not good",Balance);
        }
            Balance -= x;
            return OperationResult.failure("No money",B);
        
    }
    public void Depose(int x)
    {
        if (x <= 0)
        {
            throw new ArgumentOutOfRangeException("Initial balance cannot be nagitive or equalls zero");
        }
        Balance += x;        
    }


}