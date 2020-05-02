using System;
using System.Collections.Generic;
using System.Text;

namespace BagSimulator
{

    class Bag
    {
        public uint Apples { get; set; }
        public uint Oranges { get; set; }
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

        public int getLength()
        {
            if (fruits.Count > 2) throw new Exception("too big");
            return fruits.Count;
        }

        public void Print()
        {
            foreach (string f in fruits)
            {
                //Console.Write(f);
                //Console.Write(" "); 
            }
            //Console.WriteLine(); 
        }

        public void Shake()
        {
            if (fruits.Count > 2) throw new Exception("too big");
            Random rnd = new Random();
            int flip = 0;
            //int count = 0; 
            //string[] tempStrings = new string[2];

            //flip = rnd.Next(0, fruits.Length);

            if (flip == 1)
            {
                //fruits[0] = tempStrings[1]; 
                //fruits[1] = tempStrings[0]; 
            }

        }

        public string[] BuildNewArrray(string[] sourceArr, string[] targetArr, int exclude)
        {
            if (exclude == 0)
            {
                targetArr[0] = sourceArr[1];
            }
            else
            {
                targetArr[0] = sourceArr[0];
            }
            return targetArr;
        }

        public string Draw()
        {
            if (fruits.Count > 2) throw new Exception("too big");
            if (fruits.Count < 1) throw new Exception("too small"); 

            string[] theFruit = new string[1];
            Random rnd = new Random();
            int res = rnd.Next(0, fruits.Count);
            fruits.CopyTo(res, theFruit, 0, 1);
            fruits.RemoveAt(res);
            fruits.Capacity = 1;
            fruits.TrimExcess();
            return theFruit[0];
        }
    }

}
