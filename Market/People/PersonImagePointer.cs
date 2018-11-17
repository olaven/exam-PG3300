namespace People
{
    
    /*
      * The flyweight pattern is mainly implemented to
      * demonstrate the pattern, not because it is the most natural
      * use of it.
      */
    
    public class PersonImagePointer
    {
        /// <summary>
        /// Points to the same, static image. Will save memory,
        /// as each item will reference the same static instance 
        /// </summary>
        public static readonly PersonImage PersonImage = new PersonImage()
        {
            // Source: https://www.asky.io/191
            Image = "༼ つ ◕_◕ ༽つ"
        }; 
    }
}