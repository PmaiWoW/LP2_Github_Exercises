using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _02_ex29
{
    static class PlanetLoader
    {
        public static IEnumerable<Planet> LoadPlanets(string ficheiro)
        {
            string line;
            string[] splitLines = new string[5000];
            // Planet returnPlanet;

            using(FileStream fs = new FileStream(ficheiro, FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line[0] != '#')
                        {
                            splitLines = line.Split("\n");

                        }
                        yield return new Planet();
                        // Console.Write(line.Split("\n"));
                        // foreach(string s in splitLines)
                        // {
                        //     Console.WriteLine(s);
                        // }
                    }
                }
            }
        }
    }
}
