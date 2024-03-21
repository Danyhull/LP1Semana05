using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerUp power = PowerUp.Shield;
            int a = int.Parse(args[0]);
            Enemy[] b = new Enemy [a];
            for (int i=0; i<=(a-1); i++)
            {
                Console.WriteLine($"Nome do Inimigo {i+1}: ");
                string c =Console.ReadLine();
                b[i] = new Enemy(c);
            }
            b[0].PickupPowerUp(power, 50);
            b[0].TakeDamage(70);
            for (int i = 0; i<=(a-1); i++)
            {
                Console.WriteLine($"{b[i].GetName()} {b[i].GetHealth()} {b[i].GetShield()}" );
            }
        }
    }
}
