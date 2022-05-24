using PolTrain.Classes;
using System;

namespace PolTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var wagon = Init.CreateWagon();
            foreach(var item in wagon)
            {
                Console.WriteLine(item.WolneMiejsca);
            }

        }
    }
}
