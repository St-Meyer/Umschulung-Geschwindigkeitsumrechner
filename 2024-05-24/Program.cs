using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Settings
            Console.OutputEncoding = Encoding.UTF8;

            // Deklaration
            int input;
            double conversation_factor, output;

            // Initalisierung
            conversation_factor = 1000.0 / (60 * 60); // Von km/h zu m/s.

            // Eingabe
            Console.Write("Geschwindigkeit [km/h]: ");
            input = int.Parse(Console.ReadLine());

            // Berechnung
            output = input * conversation_factor;

            // Ausgabe
            Console.WriteLine("Umrechnungsfaktor: {0}", conversation_factor);
            Console.WriteLine("Die Geschwindigkeit {0}km/h ergibt umgerechnet "+ 
                              "in Meter pro Sekunde {1}m/s", input, output);
        }
    }
}