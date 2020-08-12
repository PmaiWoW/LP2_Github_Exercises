using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02_ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheiro = Path.Combine(Environment.GetFolderPath(
                   Environment.SpecialFolder.UserProfile),
                   @"source\repos\lp2_exercicios\problemas\02\029.tsv");
            IEnumerable<Planet> planetEnumerable;

            planetEnumerable = PlanetLoader.LoadPlanets(ficheiro);

            int numberOfPlanets =
                (from plnt in planetEnumerable
                 select plnt
                 ).Count();

            DiscoveryMethod prevalentDiscMethod =
                (from plnt in planetEnumerable
                 group plnt by plnt.DiscoveryMethod into plntGrp
                 orderby plntGrp.Count() descending
                 select plntGrp.Key
                 ).First();

            int maxExoplanetsInSingleSystem =
                ((from plnt in planetEnumerable
                  group plnt by plnt.HostSystemName into plntNameGrp
                  orderby plntNameGrp.Count() descending
                  select plntNameGrp).First()
                 ).Count();

            float averageOrbitalPeriod =
                (from plnt in planetEnumerable
                 select plnt.OrbitPeriodDays
                 ).Average();

            Planet furthestPlanet =
                (from plnt in planetEnumerable
                 orderby plnt.ParsecsDistance descending
                 select plnt
                 ).First();

            float avgTempInTwoPlusPlanetSys =
                (from plnt in planetEnumerable
                 where plnt.HostSystemName.Count() >= 2
                 group plnt by plnt.TempInKelvins into plntTempGrp
                 select plntTempGrp.Key
                ).Average();

            string facilityWithLeastDiscoveries =
                (from plnt in planetEnumerable
                 group plnt by plnt.DiscoveryFacility into plntDiscFclt
                 orderby plntDiscFclt.Count() ascending
                 select plntDiscFclt.Key
                 ).First();

            Console.WriteLine($"Number of Planets: {numberOfPlanets}");
            Console.WriteLine($"Prevalent Discovery Method: " +
                $"{prevalentDiscMethod}");
            Console.WriteLine($"Maximum Number of Exoplanets in a single " +
                $"System: {maxExoplanetsInSingleSystem}");
            Console.WriteLine($"Average Orbital Period: " +
                $"{averageOrbitalPeriod} days");
            Console.WriteLine($"Fursthest Exoplanet is " +
                $"{furthestPlanet.PlanetName}, which is " +
                $"{furthestPlanet.ParsecsDistance:f2} Parsecs away");
            Console.WriteLine($"Average Temperature of Exoplanets in " +
                $"systems with two or more Exoplanets: " +
                $"{avgTempInTwoPlusPlanetSys}");
            Console.WriteLine($"Facility with the least Discoveries: " +
                $"{facilityWithLeastDiscoveries}");
        }
    }
}
