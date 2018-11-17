namespace FleaMarket
{
    public class PersonImageFlyweightPointer
    {
        /// <summary>
        /// Points to the same, static image. Will save memory,
        /// as each item will reference the same static instance 
        /// </summary>
        public static readonly PersonImageFlyweight PersonImage = new PersonImageFlyweight
        {
            // Source: https://www.asky.io/191
            Image = "༼ つ ◕_◕ ༽つ"
        }; 
    }
}