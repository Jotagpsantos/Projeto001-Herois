using System;
using System.Collections.Generic;

namespace DIO_Herois
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            HeroiController heroiController = new HeroiController();
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
                Heroi heroi = new Heroi();
                string retornoCadastro = "";
                Console.WriteLine("Escreva seu Nome de Heroi: ");
                heroi.Nome = Console.ReadLine();
                Console.WriteLine("Informe suas Habilidades: ");
                heroi.Poder = Console.ReadLine();
                Console.WriteLine("Qual sua Vulnerabilidade: ");
                heroi.Fraqueza = Console.ReadLine();
                retornoCadastro = heroiController.CadastrarHeroi(heroi);
                Console.WriteLine(retornoCadastro);
                Console.WriteLine();
                    break;
                case "2":
                    int id;
                    id = Int32.Parse(Console.ReadLine());
                    Heroi atualizaHeroi = new Heroi();
                    string retornoAtualiza = "";
                    Console.WriteLine("Escreva seu Nome de Heroi: ");
                    atualizaHeroi.Nome = Console.ReadLine();
                    Console.WriteLine("Informe suas Habilidades: ");
                    atualizaHeroi.Poder = Console.ReadLine();
                    Console.WriteLine("Qual sua Vulnerabilidade: ");
                    atualizaHeroi.Fraqueza = Console.ReadLine();
                    retornoAtualiza = heroiController.AtualizarHeroi(atualizaHeroi, id);
                    Console.WriteLine(retornoAtualiza);
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Digite o id do Herói que deseja excluir: ");
                    int idex = Int32.Parse(Console.ReadLine());
                    heroiController.ExcluirHeroi(idex);
                    break;
                case "4":
                List<Heroi> retornoLista = new List<Heroi>();
                retornoLista = heroiController.ListarHeroi();
                    if (retornoLista.Count == 0)
                    {
                        Console.WriteLine("Não há nenhum herói cadastrado.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for(int i = 0; i < retornoLista.Count; i++)
                        {
                        
                        Console.WriteLine($"id - {i} | Nome - {retornoLista[i].Nome} | Poder - {retornoLista[i].Poder} | Fraqueza - {retornoLista[i].Fraqueza}");
                        }
                        Console.WriteLine();
                    }

                    break;
                case "5":
                    break;
            }
        } while (!opcao.Equals("5"));

        }
    }
}
