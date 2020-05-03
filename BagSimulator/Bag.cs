using System;
using System.Collections.Generic;
using System.Text;

namespace BagSimulator
{
    class Bag
    {
        
        private List<string> fruits = new List<string>();
        public Bag(uint Apples, uint Oranges)
        {

            for (uint i = 0; i < Apples; i++)
            {
                fruits.Add("apple");
            }

            for (uint i = Apples; i < (Oranges + Apples); i++)
            {
                fruits.Add("orange");
            }
        }

        public void Shake()
        {
            if (fruits.Count > 2) throw new Exception("too big");
            if (fruits.Count < 1) throw new Exception("too small");
            Random rnd = new Random(); 
            int flip = 0;
            string[] tempStrings = new string[2]; 

            flip = rnd.Next(0, fruits.Count);

            tempStrings[0] = fruits[0];
            tempStrings[1] = fruits[1];

            if ((flip != 0) && (flip != 1)) throw new Exception("bad roll"); 
            
            if (flip == 1)
            {
                fruits[0] = tempStrings[1]; 
                fruits[1] = tempStrings[0]; 
            }

        }

        public string Draw()
        {
            if (fruits.Count > 2) throw new Exception("too big");
            if (fruits.Count < 1) throw new Exception("too small");

            string theFruit; 
            Random rnd = new Random();
            int res = rnd.Next(0, fruits.Count);
            theFruit = fruits[res]; 

            //remove the chosen item from the bag
            fruits.RemoveAt(res);
            fruits.Capacity = 1;       
            fruits.TrimExcess();

            //return the item that was chosen
            return theFruit;
        }
    }
}
