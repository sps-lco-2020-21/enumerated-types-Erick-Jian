namespace EnumLibrary
{
    /// Enum type: discrete selection of options don't want; imposes restrictions on the values allowed to be chosen
    ///             - They make the varibles more readable
    ///             - Default value of the 1st item = 0
    ///             - the items after +1 each time
    ///             - values of distinct items are allowed to repeat / altered

    public enum Months 
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }

    public enum PokerCards
    {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

}
