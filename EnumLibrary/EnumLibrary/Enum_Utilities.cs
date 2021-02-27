using System;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// List.where(eachiteminlist => eachiteminlist = 0);
///     //bother rerurn new list of same type
/// List.Select(eachitem => eachitem = 0);
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

        public static int FindLongest(this List<int> straight)
        {
            /* normally people find longest run by:
             *      1. have a implicit counter variable
             *      2. check, in order, starting from the 1st card, whether is it exactly one less than the next
             *      3. if so, counter incremented by 1
             *      4. if the next value doesn't follow the criteria, store the counter somewhere else for later comparison
             *      5. repeat the steps above until the whole list've been ran through
             *      6. compare the counter value and find largest
             */

            // step 1:
            int current = 0, length = Convert.ToInt32(PokerCards.King);
            List<int> continuity = new List<int> {};
            while (current <= length)  // less than length
            {
            // step 2:
                

            }
        }
    }

    public static class CardUtilities
    {
        public static PokerCards CardStack(PokerCards stack)
        {
            return stack;
        }
    }
}
