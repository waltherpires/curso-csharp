﻿using System;

namespace IntroducaoHeranca.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }5
}
