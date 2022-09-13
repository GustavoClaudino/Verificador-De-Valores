using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_Estagio_Target
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var lista = new List<double>()
            {
                22174.1664, 24537.6698, 26139.6134, 26742.6612, 42889.2258, 46251.174, 11191.4722, 3847.4823, 373.7838, 2659.7563, 48924.2448,
                18419.2614, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 13327.1025, 25681.8318, 1718.1221, 13220.495,8414.61
            };

            Console.WriteLine($"O menor valor é: {ObterMenor(lista)}");
            Console.WriteLine($"O Maior valor é: {ObterMaior(lista)}");

            var media = ObterMedia(lista);
            Console.WriteLine($"O valor da Média é: {media}");

            int contador = 0;
            foreach (var item in lista)
            {
                if (item > media)
                {
                    contador = contador + 1;
                }
            }
            Console.WriteLine("Quantidade de dias maior que a média é: " + contador);
            Console.ReadLine();
        }
        public static double ObterMenor(List<double> lista)
        {
            return lista.Min();
        }

        public static double ObterMaior(List<double> lista)
        {
            return lista.Max();
        }

        public static double ObterMedia(List<double> lista)
        {
            return lista.Average();
        }
    }
}
