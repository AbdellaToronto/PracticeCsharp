using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    class Dog:IAnimal
    {

        public string name
        {
            get
            {
                return "Dog";
            }
            set
            {
                
            }
        }

        public bool amIFurry
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        public int toughness
        {
            get
            {
                return 7;
            }
            set
            {

            }
        }

        public void speak(string userName)
        {
            Console.WriteLine("Hello, I am a {0}, and my toughness is {1}. Your name is {2}.",name, toughness,userName);
        }
    }
}
