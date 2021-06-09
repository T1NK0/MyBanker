using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    //Inherits from Card, and makes a contract with all our interfaces we have made.
    class MasterCard: Card, IExpirationDate, ICredit, ISpendLimit, IWithdrawLimitDaily, IWithdrawLimitMonthly
    {
        private DateTime _expirationDate;
        private int _credit;
        private int _spendLimit;
        private int _withdrawLimitDaily;
        private int _withdrawLimitMonthly;

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
            string[] prefixes = {"51", "52", "53", "54", "55" };
            Random random = new Random();
            CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();

            //Sets our cardtype to "MasterCard"
            CardType = "MasterCard";
            //Creates a random prefix from our array of the available prefixes for the card
            CardPrefix = prefixes[random.Next(0, prefixes.Length)];
            //Creates a random cardnumber based off of our 
            CardNumber = cardNumberGenerator.CreateCarddNumber(CardPrefix, 16);
            //Sets the expirationdate to 5 years. (In our local time)
            ExpirationDate = DateTime.Now.AddYears(5);
            //Sets the available credit.
            Credit = 40000;
            //Sets our daily max withdraw amount.
            WithdrawLimitDaily = 5000;
            //Sets our monthly max redraw amount.
            WithdrawLimitMonthly = 30000;
        }

        public override string CardInfo()
        {
            return base.CardInfo() + "\n" +
            "Udløbsdato: " + ExpirationDate + "\n" +
            "Dagligt hævebeløb: " + WithdrawLimitDaily + "\n" +
            "Ugentlig hævebeløb: " + WithdrawLimitMonthly + "\n" +
            "Kredit: " + Credit + "\n"
            ; 
        }
    }
}
