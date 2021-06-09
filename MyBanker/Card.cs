using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public abstract class Card
    {
        private string _cardType;
        private string _cardHolder;
        private string _cardPrefix;
        private string _cardNumber;
        private string _accountNumber;

        public string CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }
        
        public string CardHolder
        {
            get { return _cardHolder; }
            set { _cardHolder = value; }
        }
        
        public string CardPrefix
        {
            get { return _cardPrefix; }
            set { _cardPrefix = value; }
        }
        
        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public Card(string cardHolder)
        {
            CardHolder = cardHolder;
        }

        //Create a virtual string method, we use as our standard method to print our card info, which we can override and add info to with the override function.
        public virtual string CardInfo()
        {
            //Print as a list looking like a credit card.
            return 
            "Kort ejer: " + CardHolder + "\n" +
            "Konto nummer: " + AccountNumber + "\n" +
            "Kort type: " + CardType + "\n" +
            "Kort nummer: " + CardNumber
            ;
        }
    }
}
