using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex65
{
    public struct Texture { }

    public class ScenarioObject
    {
        public float Weight { get; }
        public string Name { get; }

        private Texture texture; // Texture é um tipo de valor
        private List<string> attributes;
        private ScenarioAlphabet[] secretPassphrase;

        /* ...more code... */

        // ex66
        // conversões devem ser explícitas quando se sabe que se perderá
        // informação, pois se deseja que isso aconteça
        public static explicit operator string(ScenarioObject so)
        {
            StringBuilder sb = new StringBuilder();
            foreach(ScenarioAlphabet sa in so.secretPassphrase)
                sb.Append(sa.ToString());

            return sb.ToString();
        }

        public ScenarioObject Clone()
        {
            // Código do método
            ScenarioObject so = (ScenarioObject)MemberwiseClone();
            so.secretPassphrase =
                new ScenarioAlphabet[secretPassphrase.Length];
            Array.Copy(secretPassphrase, so.secretPassphrase,
                so.secretPassphrase.Length);
            return so;
        }
    }
}
