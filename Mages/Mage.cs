// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        //constructor
        public Mage(string Title) : base(Title)
        { }
        //method 
        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, this.Title);
            return storm;
        }
    }
}
