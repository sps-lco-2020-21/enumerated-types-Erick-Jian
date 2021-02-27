using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumLibrary;

namespace EnumConsole
{
    class Program
    // + static: allows passing arguments / methods WITHIN the CLASS (usually not the instance)
    //          so extensionmethods is allowed to be in the Program Class
    {
        static void Main(string[] args)
        {
            AssignPrintIncrement();
            Console.ReadKey();
            Parsing();
            Console.ReadKey();
            Casting();
            Console.ReadKey();
            IteratingFlags();           
            Console.ReadKey();
            ExtensionMethods();
            Console.ReadKey();
        }

        static void AssignPrintIncrement()
        {
            Months myMonth = Months.August;
            Console.WriteLine("{0}", myMonth);
            myMonth++;
            Console.WriteLine("{0}", myMonth);

            Console.WriteLine("{0:D}: {0:G}", myMonth);
        }

        static void Parsing()
        {
            string m = "March";
            bool success = Enum.TryParse<Months>(m, out Months mo);

            if (success)
                Console.WriteLine(mo.ToString());
            else
                Console.WriteLine("That's not a month");


            string m2 = "5";
            success = Enum.TryParse<Months>(m2, out Months mo2);

            if (success)
                Console.WriteLine(mo2.ToString());
            else
                Console.WriteLine("That's not a month");
        }

        static void Casting()
        {
            Months mo = Months.January;
            int i = (int)mo;
            mo++;

            for (int mc = 0; mc < 24; mc++)
            {
                mo++;
                Months month = (Months)mc;
                Console.WriteLine("{0}: G-{1:G} D-{1:D} {2}", mc, month, mo.ToString());

            }
        }
        static void Names()
        {

            foreach (string str in Enum.GetNames(typeof(Months)))
                Console.WriteLine(str);
        }

        static void IteratingFlags()
        {
            PokerSuits c = PokerSuits.Hearts;
            bool isRed = (c & PokerSuits.Red) == c;

            Console.WriteLine("The card's suit is: {0}", c);
            Console.WriteLine("The card is red: {0}", isRed);

            //            Console.WriteLine("Sp|Di: {0}", (Suits.Spades | Suits.Diamonds).ToString());

            for (int c2 = 0; c2 < 16; c2++)
            {
                PokerSuits s2 = (PokerSuits)c2;
                Console.WriteLine(s2);
            }
        }

        static void LongestRun()
        {
            List<int> 顺子 = new List<int> { 1, 2, 3, 4, 6, 7, 9 };
            Debug.Assert(顺子.FindLongest() == 4);
        }

        static void ExtensionMethods()
        {
            Months m = Months.January;
            Months n = MonthUtilities.NextMonth(m);
            Console.WriteLine($"The month after {m:G} is {n:G}.");

            m = Months.December;
            n = m.NextMonthE();
            Console.WriteLine($"The month after {m:G} is {n:G}.");
            m.extensionMethods();
        }
    }
    

    public static class MyExtensionMethods
    {
        public static void extensionMethods(this Months m)
        {       }

        /*
         * Consider the values of the enumerations and how they could be used to represent a run of cards 
         * (i.e. checking for a sequence of consecutive values). 
         * Develop an extension method to take a list of cards and to calculate the longest run in the list. 
         */

    }
}
