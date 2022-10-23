using System;
using static System.Net.Mime.MediaTypeNames;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm1 = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(storm1.Announce());

            Pupil pupil = new Pupil("Mezil-Kree");
            Storm pupilStorm = pupil.CastWindStorm();
            Console.WriteLine(pupilStorm.Announce());

            Mage mage = new Mage("Gul'Dan");
            Storm mageStorm = mage.CastRainStorm();
            Console.WriteLine(mageStorm.Announce());

            Archmage archmage = new Archmage("Niealas Aran");
            Storm archmageRainStorm = archmage.CastRainStorm();
            Storm archmageLightingStorm = archmage.CastLightingStorm();
            Console.WriteLine(archmageRainStorm.Announce());
            Console.WriteLine(archmageLightingStorm.Announce());




        }
    }
}