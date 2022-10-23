// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        //constructor
        public Archmage(string Title) : base(Title)
        { }
        //method
        public override Storm CastRainStorm()
        {
            Storm archmageStorm = new Storm("rain", true, this.Title);
            return archmageStorm;
        }
        public Storm CastLightingStorm()
        {
            Storm newLightingStorm = new Storm("lighting", true, this.Title);
            return newLightingStorm;
        }
    }
}
