using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02_ex29
{
    class Program
    {
        private string ficheiro;
        static void Main(string[] args)
        {
            // Program p = new Program();
            // Console.WriteLine(p.splitLines);
            // p.line = "s";
        }
        
        private Program()
        {
            ficheiro = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.UserProfile),
                @"source\repos\lp2_exercicios\problemas\02\029.tsv");
            Console.WriteLine(ficheiro);

            // splitLines = PlanetLoader.LoadPlanets(ficheiro);
        }
        
        // private void ReadInFile()
        // {
        //     FileStream fs = new FileStream(ficheiro, FileMode.Open);
        // 
        //     StreamReader sr = new StreamReader(fs);
        // 
        //     while ((line = sr.ReadLine()) != null)
        //     {
        //         if (line[0] != '#')
        //         {
        //             splitLines = line.Split("\n");
        //         }
        //     }
        // }
    }
}
