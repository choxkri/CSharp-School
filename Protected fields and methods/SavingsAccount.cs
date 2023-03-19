class SavingsAccount : BankAccount
{
    private bool _locked;

    public SavingsAccount(double balance, double interest) : base(balance, interest)
    {
        this._locked = true;
    }

    public override double Withdraw(double amount)
    {
        if (this._locked)
        {
            return 0;
        }
        
        return base.Withdraw(amount);
    }

    public override void NextYear()
    {
        this.YearsPassed++;
        if (this.YearsPassed < 5)
        {
            base.NextYear();
        }

        else
        {
            this._locked = false;
        }
    }
}