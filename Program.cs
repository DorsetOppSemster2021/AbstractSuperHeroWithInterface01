using AbstractSuperHeroWithInterface01.Models;
using System;

namespace AbstractSuperHeroWithInterface01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // SuperHero superHero = new();

            SuperMan superMan = new SuperMan();
            superMan.Fly();
            superMan.LookThroughObjects();

            Sword sword = new Sword("BatSword");
            sword.TakeDamage(5);
        }
    }
}
