using System;
using System.Collections.Generic;
using System.IO;

namespace TerjeOppgave1ReWrite
{
    public class Walk
    {
        public string Date { get; private set; }
        public double Distance { get; private set; }

        public Walk(string date, double distance)
        {
            Date = date;
            Distance = distance;
        }
         
        public static List<Walk> ReadWalksFromFile(string fileName)
        {
            var viewWalks = new List<Walk>();

            foreach (string s in File.ReadLines(fileName))
            {
                string[] userInput = s.Split(',');
                var stringDouble = userInput[1];
                var kmWalked = Double.Parse(stringDouble, System.Globalization.CultureInfo.InvariantCulture);
                var Walk = new Walk(userInput[1], kmWalked);
                viewWalks.Add(Walk);
            }
            return viewWalks;
        }
        public void printInfo(int id)
        {
            Console.WriteLine("******************************");
            Console.WriteLine($"Walk {id}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Distance {Distance} km");
        }
        public double CalculateDistance()
        {
            return Distance;
        }
    }
}