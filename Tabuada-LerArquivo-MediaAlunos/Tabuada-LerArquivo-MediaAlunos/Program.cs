using System;

namespace Tabuada_LerArquivo_MediaAlunos
{
    internal class Program
    {
        // variavel costante
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULAR_MEDIA = 3;
        public const int LIMPAR = 4;

        static void Main(string[] args)
        {
            while (true)
            {
            inicio:

                var mensagem = @"Digite uma das opções abaixo: 
                               0 - Sair do programa: 
                               1 - Ler Arquivo: 
                               2 - Tabuada:
                               3 - Caucular Media:
                               4 - Limpar:";

                Console.WriteLine("================================================");

                Console.WriteLine(mensagem);

                var opcaoEscolhida = int.Parse(Console.ReadLine());


                if (opcaoEscolhida == SAIDA_PROGRAMA)
                    break;

                if (opcaoEscolhida == LIMPAR)
                {
                    Console.Clear();
                    continue;
                }

                if (opcaoEscolhida == LER_ARQUIVO)
                {
                    Console.WriteLine("Opção le arquivo escolhida.");
                    Operacoes.LerArquivo(@"C:\arquivos\arq1.txt");
                    continue;
                }

                if (opcaoEscolhida == TABUADA)
                {
                    Console.WriteLine("Opção da tabuada escolhida.");
                    Console.WriteLine("Digite um numero.");
                    var numero = int.Parse(Console.ReadLine());
                    Operacoes.Tabuada(numero);
                    continue;
                }

                if (opcaoEscolhida == CALCULAR_MEDIA)
                {
                    Operacoes.CalcularMedia();
                    continue;
                }

                Console.WriteLine("Opção invalida digite novamaente.");
                goto inicio;

            }

            Console.ReadKey();
        }
    }
}
    

