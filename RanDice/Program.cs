using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n= int.Parse(args[0]);
            int s= int.Parse(args[1]);
            Random rand = new Random(s);
            for(int i = 0;i<n;i++)
            {
                int DiceVal = rand.Next(1,7);
                sum += DiceVal;
            }
            Console.WriteLine(sum);
        }
    }
}
