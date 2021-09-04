using System;

namespace Calcular_masa_e_altura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Calcular peso/altura²");
            Console.WriteLine("-----------------------");

            Console.WriteLine(" Informe a peso (kg): ");

            int peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Informe a altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            calcularImc(peso, altura);
        }

        static void calcularImc(int peso, double altura)
        { 
           double imc = peso /(altura * altura);
            Console.WriteLine("Imc de " + imc);

        }
    }
}
