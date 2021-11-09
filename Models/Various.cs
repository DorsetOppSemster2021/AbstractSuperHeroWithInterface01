﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSuperHeroWithInterface01.Models
{
    public abstract class SuperHero
    {
    }

    public abstract class Alien : SuperHero
    {
    }

    interface IFlyable
    {
        void Fly();
    }

    interface ISeeThroughThings
    {
        void LookThroughObjects();
    }

    public class SuperMan : Alien, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            //  throw new NotImplementedException();

            Console.WriteLine("I defy gravity");
        }

        public void LookThroughObjects()
        {
            // throw new NotImplementedException();
            Console.WriteLine("I use X-RAY Vision");
        }
    }
}
