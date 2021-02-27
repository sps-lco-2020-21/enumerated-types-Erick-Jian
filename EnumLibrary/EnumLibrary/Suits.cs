using System;

namespace EnumLibrary
{
    [Flags]     // instead of O/P the number, it O/P the variable name: (e.g. Diamonds)
    // should be used whenever the enumerable represents a collection of possible values, rather than a single value.
    //      Such collections are often used with BITWISE operators  (usually powers of 2)

    public enum PokerSuits
    {
        // binary digits: 1, 2, 4, 8
        Spades = 1, Clubs = 2, Diamonds = 4, Hearts = 8,

        // Bitwise manipulations
        Red = Diamonds | Hearts,    // |: OR
        Black = Spades | Clubs
    }

    // when manipulating member OUTSIDE of the enum class, format: EnumClass.EnumClassMember
    // e.g. string suit = (Poker_Suits.Diamonds | Poker_Suits.Hearts).ToString();
}
