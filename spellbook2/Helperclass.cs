using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellBook
{
    internal class HelperClass
    {
        public Random generator = new Random();

        public string[] PoleZTextu(string adressSource)
        {
            string obsahTxt = File.ReadAllText(adressSource);
            string[] PoleZSouboru = obsahTxt.Split(";");

            return PoleZSouboru;
        }

        public string VygenerujSpellname(string[] poleForms, string[] poleTypes)
        {
            int randomName = generator.Next(23);
            string spellName = $"{poleForms[randomName]} {poleTypes[randomName]}";

            return spellName;
        }

        public int VygenerujCislo(int max)
        {
            int randomCislo = generator.Next(max);

            return randomCislo;
        }
    }
}