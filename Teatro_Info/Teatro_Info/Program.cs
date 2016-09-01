using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatro_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0; //opcoes do menu principal
            int execucao = 0; //controla a primeira execucao
            char[,] teatro = new char[50, 50];
            int c = 0, f = 0;
            do  
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                Teatro da Etec Antonio Devisate               ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║           * * * M E N U      P R I N C I P A L * * *         ║");
                Console.WriteLine("║                [ 1 ] - ABERTURA DO TEATRO                    ║");
                Console.WriteLine("║                [ 2 ] - MAPA DE TEATRO                        ║");
                Console.WriteLine("║                [ 3 ] - PARCIAL DE VENDAS                     ║");
                Console.WriteLine("║                [ 4 ] - INGRESSOS                             ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                [ 0 ] - ENCERRAR O SISTEMA                    ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.Write("                 Qual a opção desejada:   ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        if (execucao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                Teatro da Etec Antonio Devisate               ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║  O TEATRO JÁ ESTÁ MONTADO... NÃO PRECISA EXECUTAR NOVAMENTE  ║");
                            Console.WriteLine("║              Pressione <ENTER> para continuar ...            ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (execucao == 0)
                            {
                                Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("║                Teatro da Etec Antonio Devisate               ║");
                                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                                Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("║    É obrigatório executar esta opção para tratar o teatro.   ║");
                                Console.WriteLine("║ Vamos abrir o teatro com o tamanho determinado pelo usuário. ║");
                                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                                Console.Write("Informe o tamanho do teatro (número de fileiras): ");
                                f = int.Parse(Console.ReadLine());
                                Console.Write("Informe o tamanho do teatro (número de cadeiras): ");
                                f = int.Parse(Console.ReadLine());
                                char[,] teatro1 =  new char[f, c];
                                for (int i = 0; i < f; i++)
                                {
                                    for (int j = 0; j < c; j++)
                                    {
                                        teatro[i, j] = 'V';
                                    }
                                }
                                teatro1 = teatro;
                                execucao++;
                            }
                        }
                        break;
                    case 2:
                        if (execucao == 0)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                Precisamos executar primeiro a                ║");
                            Console.WriteLine("║              opção 1 para continuar.  Pressione              ║");
                            Console.WriteLine("║              <ENTER> para voltar... Obrigado.                ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                        }
                        else
                        {
                            for (int i = 0; i < f; i++)
                            {
                                for (int j = 0; j<c; j++)
                                {
                                    Console.Write(" " + teatro[i, j]);
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        if (execucao == 0)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                Precisamos executar primeiro a                ║");
                            Console.WriteLine("║              opção 1 para continuar.  Pressione              ║");
                            Console.WriteLine("║              <ENTER> para voltar... Obrigado.                ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        else
                        {
                            //Verificar parcial de Vendas.
                        }
                        break;
                    case 4:
                        if (execucao == 0)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                Precisamos executar primeiro a                ║");
                            Console.WriteLine("║              opção 1 para continuar.  Pressione              ║");
                            Console.WriteLine("║              <ENTER> para voltar... Obrigado.                ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                            Console.ReadKey();
                        }
                        else
                        {
                            //Vender / Reservar Teatro.
                        }

                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Comando inválido");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);

        }
    }
}
