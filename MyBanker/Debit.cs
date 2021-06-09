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

            CardType = "Hævekort";
            CardPrefix = "2400";
            CardNumber = cardNumberGenerator.CreateCarddNumber(CardPrefix, 16);
        }
    }
}
