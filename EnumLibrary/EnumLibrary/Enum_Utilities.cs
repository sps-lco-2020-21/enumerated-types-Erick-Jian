using System;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// List.where(eachiteminlist => eachiteminlist = 0);
///     //bother return new list of same type
/// List.Select(eachiteminlist => eachiteminlist = 0);
/// </summary>
namespace EnumLibrary
{
    public static class MonthUtilities
    {
        public static Months NextMonth(Months current)      // months is a container that includes static functions
        {
            Months next = current + 1;
            return (Months)(((int)current + 1) % Enum.GetNames(typeof(Months)).Count());
        }

        // This is an extension method - the addition of the 'this' keyword makes for tastier syntatic sugar 
        // extension methods are STATIC and ALWAYS need to be in STATIC CLASS
        public static Months NextMonthE(this Months current)
        {
            Months next = current + 1;
            return (Months)(((int)current + 1) % Enum.GetNames(typeof(Months)).Count());

            // see also https://stackoverflow.com/a/642621/2902 with the fabulous quote
            // "with LINQ as your hammer, the world is full of nails"
        }

    // Task 2
        public static int FindLongest(this List<PokerCards> straight)
        {
            /* normally people find longest run by:
             *      1. have a implicit counter variable
             *      2. check, in order, starting from the 1st card, whether is it exactly one less than the next
             *      3. if so, counter incremented by 1
             *      4. if the next value doesn't follow the criteria, store the counter somewhere else for later comparison
             *      5. repeat the steps above until the whole list've been ran through
             *      6. compare the counter value and find largest
             */

    // METHOD 1: LINQ
            // step 1:
            int combo = 0;
            int length = Convert.ToInt32(PokerCards.King);
            List<int> PokerValue = straight.Select(x => (int)x).ToList();
                                                     // casting     -- Also can use Convert.ToInt32
            List<int> continuityMax = new List<int> {};
            List<int> continuityMin = new List<int> {};     // these are unnecessary -- I could've just create new list at LINQ

            // METHOD 3: Conversion + int list manipulation
            continuityMax = PokerValue.Where(y => PokerValue[y] + 1 != PokerValue[y + 1]).ToList();    // largest number in any run
            continuityMin = PokerValue.Where(z => PokerValue[z] - 1 != PokerValue[z - 1]).ToList();    // smallest number in any run
            var RunLength = continuityMax.Zip(continuityMin, (first, second) => first - second);                        

            return (RunLength.Max() + 1);

    // METHOD 2: iteration    
        /*  for (int count = Convert.ToInt32(PokerCards.Ace); count < length; count++)  // less than length
            {
                while (straight[count] == straight[count + 1] - 1)
                    combo ++;
                continuity.Add(combo);
            }
            return (continuity.Max());*/

    // METHOD 3: recursion ???

        /// Dealing with high/low Ace:  
        ///     if statement check (if Ace.Next = Two || King.Next = Ace)
        ///         combo ++;
        ///     otherwise continue
        /// 
        }
    }

    // Task 4
    public static class CardUtilities
    {
        /// <summary>
        /// Write an extension method for a string that converts a two character string where the first character 
        ///     is the value and the second the suit, into your Card. E.g. KD is the King of Diamonds, TH the Ten of Hearts, 5C the Five of Clubs. 
        /// </summary>
        public static string PokerCards CardStack(PokerCards stack, PokerSuits type)
        {
            return stack.ToString;
        }
    }
}
