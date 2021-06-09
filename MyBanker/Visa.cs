using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    //Inherits from card, and creates contract with the interface ExpirationDate
    class Visa :Card, IExpirationDate
    {
        //gets/sets the variable from the interface
        private DateTime _expirationDate;

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public Visa()
        {
            //Set our cardholder, card type, cardnumber(cardprefix), expirationdate, and accountnumber
            CardType = "Visa";
            CardPrefix = "4";
            CardNumber = "4";
            ExpirationDate = DateTime.Now.AddYears(5);
            //AccountNumber = 
        }
    }
}
