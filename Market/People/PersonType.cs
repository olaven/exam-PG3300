namespace People
{
    /// <summary>
    /// The possible person-types
    /// in our program.
    ///
    /// Having it as en enum provides
    /// security (compared to using
    /// strings), as the compiler will
    /// catch invalid input. 
    /// </summary>
    public enum PersonType
    {
        Salesman, Customer 
    } 
}