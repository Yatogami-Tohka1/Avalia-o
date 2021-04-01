using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class ConsoleLocadoras
    {
        public static string LocadoraSelecionada = "";
        public static void Main()
        {
            int c = 0;
            RedeLocadoras.AdicionarLocadora(new Locadora("Locadora Centro", "Rua Guaporé 789"));
            while (c == 0)
            {
                MostrarMenu();
            }           
        }
        
        
       public static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n " +
                "      Sistema de Locadoras\n " +
                "\n" +
                "1 - Criar Locadora \n" +
                "2 - Remover Locadora\n" +
                "3 - Listar Locadoras\n" +
                "4 - SelecionarLocadora\n" +
                "5 - ListarVeiculosDisponiveis\n" +
                "6 - ListarCarrosDisponíveis\n" +
                "7 - ListarAviõesDisponíveis\n" +
                "8 - ListarTodosOsVeiculo\n" +
                "9 - CadastrarCliente\n" +
                "10 - DevolverVeículo\n" +
                "11 - Listar Alugueis\n" +
                "12 - ListarAlugueisCliente\n" +
                "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    CriarLocadora();
                    break;
                case 2:
                    RemoverLocadora();
                    break;
                case 3:
                    ListarLocadoras();
                    break;
                case 4:
                    SelecionarLocadora();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                default:
                    break;
            }
        }
        public static void CriarLocadora()
        {
            Console.WriteLine("");
            Console.WriteLine("Adicionando locadora...\n" +
            "Insira o nome da sua locadora:");
            string n = Console.ReadLine();
            Console.WriteLine("Insira o endereço da locadora " + n);
            string e = Console.ReadLine();
            RedeLocadoras.AdicionarLocadora(new Locadora(n, e));
            Console.WriteLine($"Locadora {n} foi adicionada com sucesso");
        }
        public static void ListarLocadoras()
        {
            RedeLocadoras.ListarLocadoras();
        }
        public static void RemoverLocadora()
        {
            RedeLocadoras.ListarLocadoras();
            Console.WriteLine("Qual locadora voce deseja remover?");
            string Remover = Console.ReadLine();
            if(RedeLocadoras.RemoverLocadora(Remover))
            {
                Console.WriteLine($"{Remover} removida com sucesso");
            }
            else
            {
                Console.WriteLine($"Não foi possivel encontrar a locadora {Remover}");
            }
            
        }
        public static void SelecionarLocadora()
        {
            Console.WriteLine("");
            RedeLocadoras.ListarLocadoras();
            Console.WriteLine(" \n" +
                "Qual locadora voce desejar selecionar?");
            string Selecionar = Console.ReadLine();
            foreach(Locadora loc in RedeLocadoras.Locadoras)
            {
                if(loc.Nome.Equals(Selecionar))
                { 
                    LocadoraSelecionada = loc.Nome;
                }
            }
            Console.WriteLine($"{Selecionar} foi selecionada!");
        }
        public static void ListarVeiculosDisponíveis(Locadora loc)
        {
            foreach
        }
        public static void ListaAviõesDisponíveis(Locadora loc)
        {

        }
        public static void ListarCarrosDisponíveis(Locadora loc)
        {

        }
        public static void ListarTodosOsVeiculos(Locadora loc)
        {

        }
        public static void CadastrarCliente()
        {

        }
        public static void DevolverVeiculo()
        {

        }
        public static void ListarAlugueis(Locadora loc)
        {

        }
        public static void ListarAlugueisCliente(Cliente c)
        {

        }


    }
}
