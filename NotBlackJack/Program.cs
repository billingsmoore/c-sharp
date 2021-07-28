using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignmentb
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment b
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck deck = new Deck();

                // deal b cards each to d players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card aa = deck.TakeTopCard();
                Card ba = deck.TakeTopCard();
                Card ca = deck.TakeTopCard();
                Card da = deck.TakeTopCard();

                Card ab = deck.TakeTopCard();
                Card bb = deck.TakeTopCard();
                Card cb = deck.TakeTopCard();
                Card db = deck.TakeTopCard();

                // deal a more card to players b and c
                Card bc = deck.TakeTopCard();
                Card cc = deck.TakeTopCard();

                // FlipOver all the cards over
                aa.FlipOver();
                ab.FlipOver();
                
                ba.FlipOver();
                bb.FlipOver();
                bc.FlipOver();

                ca.FlipOver();
                cb.FlipOver();
                cc.FlipOver();

                da.FlipOver();
                db.FlipOver();


                // print the cards for player a
                Console.WriteLine(aa.Rank + "," + aa.Suit);
                Console.WriteLine(ab.Rank + "," + ab.Suit);
                // print the cards for player b
                Console.WriteLine(ba.Rank + "," + ba.Suit);
                Console.WriteLine(bb.Rank + "," + bb.Suit);
                Console.WriteLine(bc.Rank + "," + bc.Suit);
                // print the cards for player c
                Console.WriteLine(ca.Rank + "," + ca.Suit);
                Console.WriteLine(cb.Rank + "," + cb.Suit);
                Console.WriteLine(cc.Rank + "," + cc.Suit);
                // print the cards for player d
                Console.WriteLine(da.Rank + "," + da.Suit);
                Console.WriteLine(db.Rank + "," + db.Suit);

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}