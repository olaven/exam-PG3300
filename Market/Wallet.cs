using System;

namespace FleaMarket
{
    public class Wallet
    {
        public float Balance { get; set; }

        public Wallet()
        {
            Balance = new Random().Next(200,400);
        }
    }
}