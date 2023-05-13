using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
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

        public object Clone()
        {
            return new ChemicalElement(this.name, this.countElectrons, this.mass, this.valence);
        }
        public Atom(string name, int countElectrons, double mass, ValenceEnum valence = ValenceEnum.I, int countProtons = 0) : base(name, countElectrons, mass, valence)
        {
            this.countProtons = countProtons > 0 ? countProtons : countElectrons;
        }

        public int CountProtons { get { return countProtons; } }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Count of Protons: {countProtons}");
        }

        public object Clone()
        {
            return new Atom(this.Name, this.CountElectrons, this.Mass, this.Valence, this.countProtons);
        }
        public RadioactiveAtom(string name, int countElectrons, double mass, ValenceEnum valence = ValenceEnum.I, double halfLifePeriod = 0) : base(name, countElectrons, mass, valence)
        {
            this.halfLifePeriod = halfLifePeriod >= 0 ? halfLifePeriod : throw new ArgumentOutOfRangeException(nameof(halfLifePeriod), "Half-life period must be non-negative");
        }

        public double HalfLifePeriod { get { return halfLifePeriod; } }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Half-life period: {halfLifePeriod}");
        }

        public object Clone()
        {
            return new RadioactiveAtom(this.Name, this.CountElectrons, this.Mass, this.Valence, this.halfLifePeriod);
        }
    }
}
