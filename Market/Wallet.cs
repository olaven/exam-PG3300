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
        
        //TODO: olav wants comment about operator overloding.
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