using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class WeightFormatter : IFormattable
    {
        Animal animalToFormat { get; set; }
        public WeightFormatter(Animal animal)    
        {
            this.animalToFormat = animal;    
        }
       
        public enum Cultures { German, French, English};

        public string ToString(String? unit, IFormatProvider? formatProvider)
        {
            float outWeight = unit.ToLower() switch
            {
                "kilograms" => animalToFormat.Weight,
                "grams" => animalToFormat.Weight * 1000,
                "ounces" => animalToFormat.Weight * 35.27396f,
                "stone" => animalToFormat.Weight * 0.157473f,
                _ => throw new InvalidOperationException($"Unexpected value: {unit} please specify either: kilograms, grams, ounces, stone")
            };
            FormattableString outString = $"This {animalToFormat.GetType().Name}'s weight is {outWeight} {unit.ToLower()}";

            try
            {
                return outString.ToString(formatProvider);
            }

            catch
            {
                Console.WriteLine("HELP:::" + Environment.NewLine +
                    "================= " + Environment.NewLine +
                    "Available units:" + Environment.NewLine +
                    "kilograms" + Environment.NewLine +
                    "grams" + Environment.NewLine +
                    "ounces" + Environment.NewLine +
                    "stone" + "\n" +
                    "=================" + "\n" +
                    "Available cultures:" + "\n" +
                    "German" + "\n" +
                    "French" + "\n" +
                    "English" + "\n" +
                    "=================");
                return null;
            }
        }

        public void Help()
        {
            Console.WriteLine(
                    "================= " + "\n" +
                    "Available units:" + Environment.NewLine +
                    "kilograms" + "\n" +
                    "grams" + "\n" +
                    "ounces" + "\n" +
                    "stone" + "\n" +
                     "=================" + "\n" +
                    "Available cultures:" + "\n" +
                    "German" + "\n" +
                    "French" + "\n" +
                    "English" + "\n" +
                    "=================");
        }
    }
}
