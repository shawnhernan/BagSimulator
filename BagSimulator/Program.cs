// Copyright 2020, Shawn Hernan
using System;
namespace BagSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bertrand's Box");

            #region DeclareVariables
            Bag[] Bags = new Bag[3];
            Bag Bag0 = new Bag(2, 0);   // two apples
            Bag Bag1 = new Bag(0, 2);   // two oranges
            Bag Bag2 = new Bag(1, 1);   // one of each 
            Random rnd = new Random();
            string firstDraw, secondDraw;
            int randomBag;

            randomBag = rnd.Next(0, Bags.Length);
            Bag theBag = Bags[randomBag];

            int firstAppleDraws = 0;
            int secondOrangeDraws = 0;
            #endregion
            for (uint i = 0; i < 1000000; i++)
            {
                //create some bags, and shake them up 
                Bag0 = new Bag(2, 0); Bag1 = new Bag(0, 2); Bag2 = new Bag(1, 1); 
                Bags[0] = Bag0; Bags[1] = Bag1; Bags[2] = Bag2;
                // Bag0.Shake(); Bag1.Shake(); // no point in shaking these 
                Bag2.Shake();

                //choose a bag at random
                randomBag = rnd.Next(0, Bags.Length);
                theBag = Bags[randomBag];

                //draw two pieces of fruit from the randonly chosen bag 
                firstDraw = theBag.Draw(); 
                secondDraw = theBag.Draw(); 
               
                if (firstDraw.Equals("apple"))
                {
                    firstAppleDraws++;
                    if (secondDraw.Equals("orange")) secondOrangeDraws++; // if you drew an apple first, how many times will the second draw be an orange
                }
            }
            float ratio = (float) secondOrangeDraws / (float) firstAppleDraws; 
            Console.WriteLine("first draws {0}, secondDraws {1}, percentage {2}", firstAppleDraws, secondOrangeDraws, ratio);
        }
    }
}
