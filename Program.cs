using System;

namespace DEVinBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------Bem vindo a seu banco DEVinBank!-------------------------------\r\n\r\n\r\n---------------- Crie uma Conta Corrente, Poupança ou Investimento---------------\r\n\r\n\r\n------------------ Digite seus dados abaixo para criar sua conta ----------------\r\n\r\n\r\n");
            Console.WriteLine("Qual tipo de conta deseja?");
            var TipoDeConta  = Console.ReadLine();
            Console.WriteLine("Digita seu nome: ");
            cadastro.nome = new.nome (Console.ReadLine());
            if ( tipoConta == "1" )
            {
                Console.WriteLine("Conta Corrente")
            }   else if ( tipoConta == "2")
                {
                    Console.WriteLine("Renda Fixa");
                }
            Console.ReadKey();

        }
    }
}