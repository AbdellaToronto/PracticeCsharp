using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    interface IAnimal
    {
        string name{get; set;}
        bool amIFurry { get; set; }
        int toughness { get; set; }

        void speak(string userName);
        
    }
}
