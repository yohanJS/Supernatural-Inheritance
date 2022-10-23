// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {
        //property
        public string Title { get; private set; }
        //constructor
        public Pupil(string title)
        {
            this.Title = title;
        }
        //method
        public Storm CastWindStorm()
        {
            Storm storm = new Storm("wind", false, this.Title);
            return storm;
        }
    }
}
