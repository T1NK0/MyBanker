using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Debit : Card
    {
        public Debit(string cardHolder) : base(cardHolder)
        {
            CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();
            //Creates a prefix for our account number to get created from, since all accounts start with 3520 followed by 10 random numbers.
            string AccountNumberPrefix = "3520";

            //Sets our account number.
            AccountNumber = cardNumberGenerator.CreateCardNumber(AccountNumberPrefix, 14);
            CardType = "Hævekort";
            CardPrefix = "2400";
            CardNumber = cardNumberGenerator.CreateCardNumber(CardPrefix, 16);
        }
    }
}
