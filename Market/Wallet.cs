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
            Balance = new Random().Next(800, 1000);
        }
        
        /*
         * The operator overloading below is mainly implemented to
         * demonstrate the feature, not because it is the most natural
         * use of it.
         */
        
        public static bool operator == (Wallet wallet, float comp)
        {
            if (wallet == null)
            {
                return false;
            }
            return (int) wallet.Balance == (int) comp;
        }
        
        public static bool operator != (Wallet wallet, float comp)
        {
            if (wallet == null)
            {
                return false;
            }
            return (int) wallet.Balance != (int) comp;
        }
        public static bool operator >= (Wallet wallet, float comp)
        {
            if (wallet == null)
            {
                return false;
            }
            return (int) wallet.Balance >= (int) comp;
        }
        public static bool operator <= (Wallet wallet, float comp)
        {
            if (wallet == null)
            {
                return false;
            }
            return (int) wallet.Balance <= (int) comp;
        }
    }
}