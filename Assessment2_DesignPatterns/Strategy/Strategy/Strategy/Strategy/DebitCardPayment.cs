﻿namespace Strategy
{
    public class DebitCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer paid PHP " + amount + " using Debit Card");
        }
    }
}
