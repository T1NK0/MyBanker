using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Maestro : Card, IExpirationDate
    {
        private DateTime _expirationDate;

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public Maestro(string cardHolder) : base(cardHolder)
        {
            //Creates a string array with our prefixes available.
            string[] prefixes = { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"};
            Random random = new Random();
            CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();

            //Sets our cardtype to "Maestro"
            CardType = "Maestro";
            //Creates a random prefix from our array of the available prefixes for the card
            CardPrefix = prefixes[random.Next(0, prefixes.Length)];
            //Creates a random cardnumber based off of our prefix numbers and rest is random generated numbers added to the string.
            CardNumber = cardNumberGenerator.CreateCarddNumber(CardPrefix, 19);
            //Sets the expirationdate to 5 years and 8 months, from card creation time.
            ExpirationDate = DateTime.Now.AddYears(5).AddMonths(8);
        }

        //Create an override of the CardInfo so we show our extra interface values we use in this card.
        public override string CardInfo()
        {
            return base.CardInfo() + "\n" +
            "Udløbsdato: " + ExpirationDate + "\n" +
            "-------------------------"
            ;
        }
    }
}
