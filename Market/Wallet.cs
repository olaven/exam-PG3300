using System;

namespace FleaMarket
{
    /// <summary>
    /// This class encapsulates the
    /// concept of a wallet, containing
    /// money
    /// </summary>
    public class Wallet
    {
        public float Balance { get; set; }

        public Wallet()
        {
            Balance = new Random().Next(200,400);
        }
    }
}