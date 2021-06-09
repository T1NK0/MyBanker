using System;
using System.Collections.Generic;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cardList = new List<Card>();
            ////Create our objects / cards

            MasterCard masterCard = new MasterCard("Svend Eriksen");


            cardList.Add(masterCard);

            foreach (Card card in cardList)
            {
                Console.WriteLine(card.CardInfo());
            }

            //Square square = new Square(90, "Kvadrat");
            //Rektangel rektangel = new Rektangel(20, 40, "Rektangel");
            //Paralellogram paralellogram = new Paralellogram(20, 30, 5, "Paralellogram");
            //Trapez trapez = new Trapez(50, 15, 30, 15, "Trapez");
            //Triangle triangle = new Triangle(25, 25, "Retvinklet Trekant");

            //shapes.Add(square);
            //shapes.Add(rektangel);
            //shapes.Add(paralellogram);
            //shapes.Add(trapez);
            //shapes.Add(triangle);

            ////Loop through the shapes in the list.
            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine(shape.Name + "\n" + shape.calculateAreal() + "\n" + shape.calculatePerimeter() + "\n" + "\n");
            //}
        }
    }
}
