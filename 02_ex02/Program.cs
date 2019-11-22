using System;
using System.Collections.Generic;

namespace _02_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar variável do tipo IEnumerable<IUnit> e testar guardar uma
            // lista na mesma
            IEnumerable<IUnit> unitBundle1 = new List<IUnit>()
            {
                new Unit("Lancer", new Vector2(1f, 1f), 100f),
                new Unit("Assassin", new Vector2(1f, 2f), 80f),
                new Unit("Caster", new Vector2(1f, 3f), 90f)
            };

            // Criar variável do tipo Squad, guardando na mesma os conteúdos 
            // da variável unitBundle1
            Squad squad1 = new Squad(unitBundle1);

            // Criar variável do tipo IEnumerable<IUnit> e testar guardar um 
            // hashset na mesma
            IEnumerable<IUnit> unitBundle2 = new HashSet<IUnit>()
            {
                new Unit("Saber", new Vector2(2f, 1f), 150f),
                new Unit("Ruler", new Vector2(2f, 2f), 200f),
                new Unit("Rider", new Vector2(2f, 3f), 140f),
                new Unit("Archer", new Vector2(2f, 4f), 110f),
                new Unit("Berserker", new Vector2(2f, 5f), 170f)
            };

            // Criar variável do tipo Squad, guardando na mesma os conteúdos 
            // da variável unitBundle2
            Squad squad2 = new Squad(unitBundle2);

            // Testar a adição de unidades a squad2, após a sua criação,
            // através do método próprio para o mesmo
            squad2.AddUnit(squad1);

            // Percorrer ambos squads, imprimindo o ToString() de cada IUnit
            // contida nos mesmos (variáveis de tipo Squad contidas noutra 
            // variável de tipo Squad são tratadas como IUnit também)
            Console.WriteLine("1st Squad's Units:");
            foreach(IUnit u in squad1.UntCol) Console.WriteLine(u);
            Console.WriteLine("\n2nd Squad's Units:");
            foreach(IUnit u in squad2.UntCol) Console.WriteLine(u);

            // Imprimir os ToString() de ambos Squads
            Console.WriteLine("\n1st Squad's description:");
            Console.WriteLine(squad1);
            Console.WriteLine("\n2nd Squad's description:");
            Console.WriteLine(squad2);

            // Chamar método Move() de ambos Squads, dando-lhes o mesmo vetor,
            // para motivos de teste
            Console.WriteLine("\nMoving both squads' units...\n");
            squad1.Move(new Vector2(5f, 5f));
            squad2.Move(new Vector2(5f, 5f));

            // Percorrer ambos squads, imprimindo o ToString() de cada IUnit
            // contida nos mesmos
            Console.WriteLine("1st Squad's Units after move:");
            foreach (IUnit u in squad1.UntCol) Console.WriteLine(u);
            Console.WriteLine("\n2nd Squad's Units after move:");
            foreach (IUnit u in squad2.UntCol) Console.WriteLine(u);
        }
    }
}
