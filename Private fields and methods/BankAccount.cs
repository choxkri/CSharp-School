class BankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        this._balance = balance;
    }

    public double ReadBalance() 
    { 
        return _balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0) 
        {
            this._balance += amount;
        }
    }

    public double Withdraw(double amount) 
    {
        bool check = SufficientBalance(amount);
        if (check) 
        {
            this._balance -= amount;
            return this._balance;
        }

        if (amount < 0 | check == false) 
        {
            return 0;
        }

        return 0;
    }

    private bool SufficientBalance(double amount) 
    {
        if (this._balance < amount) 
        {
            return false;
        }

        return true;
    }
}