using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    //Inherits from card, and creates contract with the interface ExpirationDate
    class Visa : Card, IExpirationDate, IWithdrawLimitMonthly, ISpendLimit
    {
        //gets/sets the variable from the interface
        private DateTime _expirationDate;
        private int _withdrawLimitMonthly;
        private int _spendLimit;

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public int WithdrawLimitMonthly
        {
            get { return _withdrawLimitMonthly; }
            set { _withdrawLimitMonthly = value; }
        }

        public int SpendLimit
        {
            get { return _spendLimit; }
            set { _spendLimit = value; }
        }

        public Visa(string cardHolder) : base(cardHolder) 
        {
            CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();
            //Creates a prefix for our account number to get created from, since all accounts start with 3520 followed by 10 random numbers.
            string AccountNumberPrefix = "3520";

            //Sets our account number.
            AccountNumber = cardNumberGenerator.CreateCarddNumber(AccountNumberPrefix, 14);
            //Sets our cardtype to "Visa"
            CardType = "Visa";
            //Creates the cards prefix (4 is the only option here)
            CardPrefix = "4";
            //Creates a random cardnumber based off of our prefix numbers and rest is random generated numbers added to the string.
            CardNumber = cardNumberGenerator.CreateCarddNumber(CardPrefix, 16);
            //Sets the expirationdate to 5 years, from card creation time.
            ExpirationDate = DateTime.Now.AddYears(5);
            //Sets our monthly withdraw limti to 25000
            WithdrawLimitMonthly = 25000;
            //Sets our spending limit to 20000
            SpendLimit = 20000;
        }

        //Create an override of the CardInfo so we show our extra interface values we use in this card.
        public override string CardInfo()
        {
            return base.CardInfo() + "\n" +
            "Udløbsdato: " + ExpirationDate.ToShortDateString() + "\n" +
            "Ugentlig hævebeløb: " + WithdrawLimitMonthly + "\n" +
            "Brugs begrænsning:: " + SpendLimit + "\n" +
            "-------------------------"
            ;
        }
    }
}
