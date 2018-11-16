namespace Item
{
    /// <summary>
    /// The possible decorations
    /// we have implemented for
    /// an item.
    ///
    /// Having it as en enum provides
    /// security (compared to using
    /// strings), as the compiler will
    /// catch invalid input. 
    /// </summary>
    public enum Decoration
    {
        ModerateDamage,
        MultipleDamage,
        NoDamage,
        DecentCondition,
        PerfectCondition,
        TerribleCondition,
        WithTrumpStickers,
        WithWheels,
        WithWings, 
        NoDecoration
    }
}