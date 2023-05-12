using System;
using System.Globalization;
using System.IO;

namespace Tabuada_LerArquivo_MediaAlunos
{
    public static class Operacoes
    {
        public static void Tabuada(int numero)
        {
            Console.WriteLine("=== o resutado da tabuada de " + numero + " é ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

        }

        public static void LerArquivo(string nomeArquivo)
        {
            using (var arquivo = File.OpenText(nomeArquivo))
            {
                var linha = string.Empty;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite as notas dos tres semestres.");
            Console.WriteLine("Digite a primeira nota.");
            var primeiraNota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota.");
            var segundaNota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota.");
            var terceiraNota = Convert.ToDouble(Console.ReadLine());

            var resultado = 0M;
            resultado = Convert.ToDecimal((primeiraNota + segundaNota + terceiraNota) / 3);
            if (resultado >= 5)
            {
                Console.WriteLine("Sua media Final é de = " + resultado.ToString("N1", new CultureInfo("pt-BR")));
                Console.WriteLine("Voce esta aprovado.");
                return;
            }

            Console.WriteLine("Sua media Final é de = " + resultado.ToString("N1", new CultureInfo("pt-BR")));
            Console.WriteLine("Voce esta reprovado.");
        }
    }
}

