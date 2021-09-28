using System;

namespace DIO_Herois
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
        do
        {
            Console.WriteLine("Bem vindo a Liga de Heróis");
            Console.WriteLine();
            Console.WriteLine("1 - Aliste-se");
            Console.WriteLine("2 - Atualizar registro");
            Console.WriteLine("3 - Excluir registro");
            Console.WriteLine("4 - Heróis já Registrados");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                Console.WriteLine("CadastrarHeroi()");
                    break;
                case "2":
                Console.WriteLine("AtualizarHeroi()");
                    break;
                case "3":
                 Console.WriteLine("ExcluirHeroi()");
                    break;
                case "4":
                 Console.WriteLine("ListarHeroi()");
                    break;
                case "5":
                    break;
            }
        } while (!opcao.Equals("5"));

        }
    }
}
