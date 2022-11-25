using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            paralelipiped dreptunghic, va afisa volumul lui*/

            int lungime = int.Parse(Console.ReadLine());
            int latime = int.Parse(Console.ReadLine());
            int inaltime = int.Parse(Console.ReadLine());

            int volum = lungime * latime * inaltime;
            Console.WriteLine(volum);
        }
    }
}
