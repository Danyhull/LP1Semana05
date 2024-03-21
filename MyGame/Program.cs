using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(args[0]);
            Enemy[] b = new Enemy [a];
            for (int i=0; i<=(a-1); i++)
            {
                Console.WriteLine($"Nome do Inimigo {i+1}: ");
                string c =Console.ReadLine();
                b[i] = new Enemy(c);
            }
            for (int i = 0; i<=(a-1); i++)
            {
                Console.WriteLine($"{b[i].GetName()} {b[i].GetHealth()} {b[i].GetShield()}" );
            }
        }
    }
}
