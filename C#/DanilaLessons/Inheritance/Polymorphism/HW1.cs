using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;
class Account
{
    public double Balance { get; set; }

    public Account(double balance)
    {
        Balance = balance;
    }

    public virtual double CalculateInterest()
    {
        return 0; 
    }
}

// Saving acc — 5% 
class SavingsAccount : Account
{
    public SavingsAccount(double balance) : base(balance) { }

    public override double CalculateInterest()
    {
        return Balance * 0.05;
    }
}

// Deposit — 10% 
class DepositAccount : Account
{
    public DepositAccount(double balance) : base(balance) { }

    public override double CalculateInterest()
    {
        return Balance * 0.10;
    }
}

// Credit 3%
class LoanAccount : Account
{
    public LoanAccount(double balance) : base(balance) {}

    public override double CalculateInterest()
    {
        return -Balance * 0.03;
    }
}

