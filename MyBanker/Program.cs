using System;
using System.Collections.Generic;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create our list containing our cards
            List<Card> cardList = new List<Card>();

            ////Create our objects / cards
            MasterCard masterCard = new MasterCard("Svend Eriksen");
            Visa visa = new Visa("Lars Larsen");
            VisaElectron visaElectron = new VisaElectron("Bob Svendsen");
            Maestro maestro = new Maestro("Anders Andersen");
            Debit debit = new Debit("Carl Johan");

            cardList.Add(masterCard);
            cardList.Add(visa);
            cardList.Add(visaElectron);
            cardList.Add(maestro);
            cardList.Add(debit);

            foreach (Card card in cardList)
            {
                Console.WriteLine(card.CardInfo());
            }
        }
    }
}
