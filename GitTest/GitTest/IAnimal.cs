using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    interface IAnimal
    {
        string name;
        bool amIFurry;
        int toughness;

        public void speak(string userName)
        {
            Console.WriteLine("I'm a {0}, and my toughness level is {1}. Your name is {2}",name, toughness,userName);
        }
    }
}
