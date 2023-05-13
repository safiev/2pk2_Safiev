using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public class MyClass
        {
            private int _field1;
            private string _field2;

            
            public MyClass()
            {
                _field1 = 0;
                _field2 = "default value";
            }

           
            public MyClass(int value)
            {
                _field1 = value;
                _field2 = "default value";
            }

           
            public MyClass(int value, string text)
            {
                _field1 = value;
                _field2 = text;
            }

       
            public int GetField1()
            {
                return _field1;
            }
        }
      

        public class ChemicalElement
        {
            private string name;
            private int countElectrons;
            private double mass;
            private int valence;

           
            public ChemicalElement()
            {
                name = "Unknown";
                countElectrons = 0;
                mass = 0;
                valence = 0;
            }

          
            public ChemicalElement(string name, int countElectrons, double mass, int valence)
            {
                this.name = name;
                this.countElectrons = countElectrons;
                this.mass = mass;
                this.valence = valence;
            }

            
            public void PrintInfo()
            {
                Console.WriteLine($"Element: {name}, Electrons: {countElectrons}, Mass: {mass}, Valence: {valence}");
            }
        }

    }
}
    

