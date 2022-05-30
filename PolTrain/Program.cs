using PolTrain.Classes;
using System;

namespace PolTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var wagon = Init.CreateWagon();
            var pociag2 = Init.CreatePociag2();

            foreach(var item in wagon)
            {
                Console.WriteLine(item.WolneMiejsca);
            }

        }
    }
}
