using System;
using System.Collections.Generic;
using System.IO;

namespace TerjeOppgave1ReWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalDistance = 0.0;
            var id = 1;
            string filePath = "C:\\Users\\GET Academy\\Desktop\\Modul 3 Prosjekter\\TerjeOppgave1ReWrite\\TerjeOppgave1ReWrite\\myWalks – Kopi – Kopi.txt";
            var WalkList = Walk.ReadWalksFromFile(filePath);

            foreach (var Walk in WalkList)
            {
                Walk.printInfo(id);
                id++;
                totalDistance = totalDistance + Walk.CalculateDistance();
            }
            Console.WriteLine("*********************");
            Console.WriteLine($"Nice Work! You've walked a total distance of {totalDistance} km");
            Console.WriteLine("*********************");
        }
    }
}
