using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    //Inherits from Card, and makes a contract with all our interfaces we have made which is needed for the mastercard.
    class MasterCard : Card, IExpirationDate, ICredit, ISpendLimit, IWithdrawLimitDaily, IWithdrawLimitMonthly
    {
        //Our attributes from our interfaces
        private DateTime _expirationDate;
        private int _credit;
        private int _spendLimit;
        private int _withdrawLimitDaily;
        private int _withdrawLimitMonthly;

        //Our properties from our interfaces
        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public int Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }

        public int SpendLimit
        {
            get { return _spendLimit; }
            set { _spendLimit = value; }
        }

        public int WithdrawLimitDaily
        {
            get { return _withdrawLimitDaily; }
            set { _withdrawLimitDaily = value; }
        }

        public int WithdrawLimitMonthly
        {
            get { return _withdrawLimitMonthly; }
            set { _withdrawLimitMonthly = value; }
        }

        public MasterCard(string cardHolder) : base(cardHolder)
        {
            //Creates a string array with our prefixes available.
            string[] prefixes = {"51", "52", "53", "54", "55"};
            Random random = new Random();
            CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();
            //Creates a prefix for our account number to get created from, since all accounts start with 3520 followed by 10 random numbers.
            string AccountNumberPrefix = "3520";
            
            //Sets our account number.
            AccountNumber = cardNumberGenerator.CreateCarddNumber(AccountNumberPrefix, 14);
            //Sets our cardtype to "MasterCard"
            CardType = "MasterCard";
            //Creates a random prefix from our array of the available prefixes for the card
            CardPrefix = prefixes[random.Next(0, prefixes.Length)];
            //Creates a random cardnumber based off of our prefix numbers and rest is random generated numbers added to the string.
            CardNumber = cardNumberGenerator.CreateCarddNumber(CardPrefix, 16);
            //Sets the expirationdate to 5 years, from card creation time.
            ExpirationDate = DateTime.Now.AddYears(5);
            //Sets the available credit.
            Credit = 40000;
            //Sets our daily max withdraw amount.
            WithdrawLimitDaily = 5000;
            //Sets our monthly max redraw amount.
            WithdrawLimitMonthly = 30000;
        }

        //Create an override of the CardInfo so we show our extra interface values we use in this card.
        public override string CardInfo()
        {
            return base.CardInfo() + "\n" +
            "Udløbsdato: " + ExpirationDate + "\n" +
            "Dagligt hævebeløb: " + WithdrawLimitDaily + "\n" +
            "Ugentlig hævebeløb: " + WithdrawLimitMonthly + "\n" +
            "Kredit: " + Credit + "\n" +
            "-------------------------"
            ; 
        }
    }
}
