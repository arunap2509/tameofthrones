using System;
using TameOfThrones.geektrust;

namespace geektrust
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Please provide the path to the messages");
                return;
            }

            Southeros southeros = new Southeros(args[0]);
            southeros.GetRulerAndAllies();
        }
    }
}