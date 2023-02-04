using DesafioContaBancaria.Entities.Exceptions;
using System.Globalization;

namespace DesafioContaBancaria.Entities {
    internal class Account {
        public int Number { get; set; }
        public string? Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string? holder, double balance, double withdrawLimit) {
            if (balance < 0) {
                throw new DomainException("balance value must be greater than or equal to 0");
            }
            else if (withdrawLimit < 0) {
                throw new DomainException("withDrawal Limit value must be greater than or equal to 0");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            if (amount < 0) {
                throw new DomainException("Amount Limit value must be greater than or equal to 0");
            }
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (amount <= 0) {
                throw new DomainException("Amount withdrawal limit must be greater  than 0");
            }
            else if (amount > WithdrawLimit) {
                throw new DomainException("The amount exeeds withdraw limit");
            }
            else if (amount > Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString() {
            return "New balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
