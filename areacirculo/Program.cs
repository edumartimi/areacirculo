using System;
using System.Globalization;

namespace areacirculo
{
    class Program
    {
        static void Main(string[] args) {

            calculadora calc = new calculadora();

            Console.WriteLine("Entre com valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);


            Console.WriteLine("Circuferência: " +circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " +volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
