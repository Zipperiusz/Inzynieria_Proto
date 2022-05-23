using PolTrain.Classes;
using System;

namespace PolTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bilet bw = new(5, "", DateTime.Now,5);
            bw.KupBilet();
        }
    }
}
