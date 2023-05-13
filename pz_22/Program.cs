using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public class ChemicalElement
        {
            private string name;
            private int countElectrons;
            private double mass;
            private ValenceEnum valence;

            private static int countValence1 = 0;
            private static int countValence2 = 0;

            public ChemicalElement(string name, int countElectrons, double mass, ValenceEnum valence = ValenceEnum.I)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentNullException(nameof(name));
                this.countElectrons = countElectrons > 0 ? countElectrons : throw new ArgumentOutOfRangeException(nameof(countElectrons), "Count of electrons must be greater than zero");
                this.mass = mass > 0 ? mass : throw new ArgumentOutOfRangeException(nameof(mass), "Mass must be greater than zero");
                this.valence = valence;

                if (valence == ValenceEnum.I) countValence1++;
                if (valence == ValenceEnum.II) countValence2++;
            }

            public string Name { get { return name; } }
            public int CountElectrons { get { return countElectrons; } }
            public double Mass { get { return mass; } }
            public ValenceEnum Valence { get { return valence; } }

            public void PrintInfo()
            {
                Console.WriteLine($"Name: {name}, Count of Electrons: {countElectrons}, Mass: {mass}, Valence: {valence}");
            }

            public static void PrintValenceCounts()
            {
                Console.WriteLine($"Count of elements with valence 1: {countValence1}");
                Console.WriteLine($"Count of elements with valence 2: {countValence2}");
            }
        }

        public enum ValenceEnum
        {
            I,
            II,
            III,
            IV,
            V
        }
    }
}
