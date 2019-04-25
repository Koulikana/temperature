using System;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez une température en Celsius :");
            double t = Convert.ToDouble(Console.ReadLine());
            var convertisseur = new ConvertisseurFarenheit(t);
            Console.WriteLine("Conversion en farenheit : {0}",  convertisseur.Farenheit);
        }
    }
}
