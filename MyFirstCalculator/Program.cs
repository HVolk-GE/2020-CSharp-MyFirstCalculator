using System;

namespace MyFirstCalculator
{
    class Program
    {
        ///<param name="args"></param>
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.

            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Convension String in Integer
            // int IntSummand1 = Convert.ToInt32(StrSumand1);
            // int IntSummand2 = Convert.ToInt32(StrSumand2);

            // Convension String in double ("float")
            float ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

            // Convension String in double ("float")
            // double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            // double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen
            //int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            float summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            //double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
        }
    }
}
