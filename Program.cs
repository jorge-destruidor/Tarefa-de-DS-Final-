using System;
using System.Globalization;
using System.Collections.Generic;
using Tarefaa.Entidades;

namespace Tarefaa
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contrato> list = new List<Contrato>();
            Console.Write("Quantos contratos serão: ");
            int n = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= n; cont++)
            {
                 Console.WriteLine();
                Console.WriteLine($"Dados do contrato #{cont} :");
                Console.Write("Contrato Jurídico ou Físico (J/F)? ");
                char choice = char.Parse(Console.ReadLine());

                do
                {
                    if (choice == 'j' || choice == 'J' || choice == 'f' || choice == 'F')
                    {
                        break;
                    }
                    Console.WriteLine("Erro!!!");
                    Console.WriteLine();
                    Console.WriteLine($"Dados do contrato #{cont} -");

                    Console.Write("Qual o tipo do contrato - Jurídico ou Físico (J/F)?  ");
                    choice = char.Parse(Console.ReadLine());

                } while (choice != 'j' || choice != 'J' || choice != 'f' || choice != 'F');



                if (choice == 'j' || choice == 'J')
                {
                    Console.Write("Numero: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Write("Contratante: ");
                    string contratante = Console.ReadLine();
                    Console.Write("Valor: $");
                    double valor = double.Parse(Console.ReadLine());
                    Console.Write("Prazo [meses]: ");
                    int prazo = int.Parse(Console.ReadLine());
                    Console.Write("Cnpj: ");
                    string cnpj = Console.ReadLine();
                    Console.Write("Inscrição estadual: ");
                    string inscricaoEstadual = Console.ReadLine();

                    ContratoPJuridica wow = new ContratoPJuridica();

                    wow.CalcularPrestacao();

                    list.Add(new ContratoPJuridica(numero, contratante, valor, prazo, cnpj, inscricaoEstadual));
                }

                else if (choice == 'f' || choice == 'F')
                {
                    Console.Write("Numero: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Write("Contratante: ");
                    string contratante = Console.ReadLine();
                    Console.Write("Valor: $");
                    double valor = double.Parse(Console.ReadLine());
                    Console.Write("Prazo [meses]: ");
                    int prazo = int.Parse(Console.ReadLine());
                    Console.Write("CPF: ");
                    string cpf = Console.ReadLine();
                    Console.Write("Idade contratante: ");
                    int idadeContratante = int.Parse(Console.ReadLine());

                    ContratoPFisica wew = new ContratoPFisica();

                    wew.CalcularPrestacao();

                    list.Add(new ContratoPFisica(numero, contratante, valor, prazo, cpf, idadeContratante));
                }






            }



            
            Console.WriteLine("Segue as informações");
       

            foreach (Contrato hehe in list)
            {

                Console.WriteLine();
                Console.WriteLine(hehe.Intel());
            }

            
        }
    }
}
