class BankAccount
{
    private double _balance;
    protected int YearsPassed;
    protected double InterestRate;

    public BankAccount(double balance, double interest)
    {
        this._balance = balance;
        this.InterestRate = interest;
        this.YearsPassed = 0;
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

    public virtual double Withdraw(double amount)
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

    protected void ApplyInterest()
    {
        this._balance += this._balance * this.InterestRate;
    }

    public virtual void NextYear()
    {
        ApplyInterest();
    }
}