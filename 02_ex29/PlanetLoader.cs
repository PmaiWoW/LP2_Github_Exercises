using System;
using System.Collections.Generic;
using System.IO;

namespace _02_ex29
{
    static class PlanetLoader
    {
        public static IEnumerable<Planet> LoadPlanets(string ficheiro)
        {
            // Define local variables
            string line;
            string[] elements;
            string[] discMtdParseArray;
            Planet returnPlanet;

            using (FileStream fs = new FileStream(ficheiro, FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line[0] != '#' && Int32.TryParse($"{line[0]}",
                            out int firstChar))
                        {
                            elements = line.Split("\t");

                            // TryParse ID into it's own variable
                            int.TryParse($"{elements[0]}", out int id);
                            // TryParse PlanetLetter into it's own variable
                            char.TryParse(elements[2], out char plntLtr);
                            // Split Discovery Method string, join
                            // into a single string and TryParse into it's
                            // own variable
                            discMtdParseArray = elements[4].Split(" ");
                            string tempString = "";
                            foreach(string strArr in discMtdParseArray)
                            {
                                tempString += strArr;
                            }
                            elements[4] = tempString;
                            if (!Enum.TryParse(elements[4],
                                out DiscoveryMethod dscMt))
                                Console.WriteLine($"Carallo, dis no work!" +
                                    $" ID: {id}");
                            // TryParse OrbitalPeriod into it's own variable
                            float.TryParse(elements[5], out float orbtPrd);
                            // TryParse ParsecDistance into it's own variable
                            float.TryParse(elements[6], out float parsDist);
                            // TryParse TempInKelvins into it's own variable
                            float.TryParse(elements[7], out float tmpInKlv);

                            returnPlanet = new Planet(
                                id,
                                elements[1],
                                plntLtr,
                                elements[3],
                                dscMt,
                                orbtPrd,
                                parsDist,
                                tmpInKlv,
                                elements[8]);

                            yield return returnPlanet;
                        }
                    }
                }
            }
        }
    }
}