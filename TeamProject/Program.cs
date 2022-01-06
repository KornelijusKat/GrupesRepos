using System;

namespace TeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double earthArea = 0;
            double earthVolume = 0;
            double izambine = 0;

            //Pirma Uzduotis
            double radius = 6371;
            earthArea = 4 * Math.PI * (radius * radius);
            //Antra Uzduotis
            earthVolume = (4 / 3) * Math.PI * radius * radius;


            double border1 = 10;
            double border2 = 15;

            double izambine = Math.Sqrt(border1 * border1 + border2 * border2);

            Console.WriteLine($"{izambine}");
            //Isvestis
            Console.WriteLine("*************************************************");
            Console.WriteLine($"Kintamasis 1: {earthArea}");
            Console.WriteLine($"Kintamasis 2: {earthVolume}");
            Console.WriteLine($"Kintamasis 3: {izambine}");
            Console.WriteLine("Kintamuju suma yra: {0}", earthArea + earthVolume + izambine);
            Console.WriteLine("Kintamuju vidurkis yra: {0}", (earthArea + earthVolume + izambine) / 3);
            Console.WriteLine("*************************************************");
            Console.ReadLine();

        }
    }
}
