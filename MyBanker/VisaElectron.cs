using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class VisaElectron : Card, IExpirationDate, ISpendLimit
    {
        private int _spendLimit;
        private DateTime _expirationDate;

        public int SpendLimit
        {
            get { return _spendLimit; }
            set { _spendLimit = value; }
        }

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardHolder">The name of the cardholder</param>
        public VisaElectron(string cardHolder) : base(cardHolder)
        {
            //Creates a string array with our prefixes available.
            string[] prefixes = {"4026", "417500", "4508", "4844", "4913", "4917"};
            Random random = new Random();
            CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();

            //Sets our cardtype to "MasterCard"
            CardType = "VisaElectron";
            //Creates a random prefix from our array of the available prefixes for the card
            CardPrefix = prefixes[random.Next(0, prefixes.Length)];
            //Creates a random cardnumber based off of our prefix numbers and rest is random generated numbers added to the string.
            CardNumber = cardNumberGenerator.CreateCarddNumber(CardPrefix, 16);
            //Sets the expirationdate to 5 years, from card creation time.
            ExpirationDate = DateTime.Now.AddYears(5);
            //Sets the visaElectron max spendinglimit to 25000.
            SpendLimit = 10000;
        }

        //Create an override of the CardInfo so we show our extra interface values we use in this card.
        public override string CardInfo()
        {
            return base.CardInfo() + "\n" +
            "Udløbsdato: " + ExpirationDate + "\n" +
            "Brugs begrænsning: " + SpendLimit + "\n" +
            "-------------------------"
            ;
        }
    }
}
