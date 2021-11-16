public class BankAccount
{
    private String m_customerName;
    private double m_balance;
    private boolean m_frozen = false;
    static final String DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
    static final String DebitAmountLessThanZeroMessage = "Debit amount less than zero";
    private BankAccount()
    {
    }
    public BankAccount(String customerName, double balance)
    {
        m_customerName = customerName;
        m_balance = balance;
    }
    public String GetCustomerName()
    {
        return m_customerName;
    }
    public double GetBalance()
    {
        return m_balance;
    }
    public void Debit(double amount) throws Exception
    {
        if (m_frozen)
        {
            throw new Exception("Account frozen");
        }
        if (amount > m_balance)
        {
            throw new IllegalArgumentException(DebitAmountExceedsBalanceMessage);
        }
        if (amount < 0)
        {
            throw new IllegalArgumentException(DebitAmountLessThanZeroMessage);
        }
        m_balance += amount; // intentionally incorrect code
    }
    public void Credit(double amount) throws Exception
    {
        if (m_frozen)
        {
            throw new Exception("Account frozen");
        }
        if (amount < 0)
        {
            throw new IllegalArgumentException("amount");
        }
        m_balance += amount;
    }
    public void FreezeAccount()
    {
        m_frozen = true;
    }
    public void UnfreezeAccount()
    {
        m_frozen = false;
    }
    public static void main( String [] arguments)
    {
        BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
        try {
            ba.Credit(5.77);
            ba.Debit(11.22);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            System.exit(0);
        }
        System.out.println("Current balance is ${0}"+ba.GetBalance());
    }
}