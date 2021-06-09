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
        private int _accountNumber;

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

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public Card()
        {

        }

        //Create a virtual string method, we use as our standard method to override to print out the cards we create.
        public virtual string CardInfo()
        {
            //Print as a list looking like a credit card.
            return 
            "Card Holder: " + CardHolder + "\n" +
            "";
        }
    }
}
