using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class CardNumberGenerator
    {
        public string CreateCardNumber(string prefix, int cardNumberLength)
        {
            //Creates a random number generator.
            Random random = new Random();

            //Creates a string we call cardnumbers, which holds our prefix, since it needs to be the start of the cardnumber.
            string cardNumbers = prefix;

            //Loops through our cardnumbers string for the length of it, until it is the desired length (cardNumberLength).
            for (int i = 0; cardNumbers.Length < cardNumberLength; i++)
            {
                //adds a new number to our string "cardNumbers
                cardNumbers += random.Next(0, 9).ToString();
            }
            return cardNumbers;
        }
    }
}
