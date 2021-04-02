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
            RedeLocadoras.AdicionarLocadora(new Locadora("Locadora Yvete Dias", "Rua Yvete Dias da Silva 60"));
            foreach (Locadora loc in RedeLocadoras.Locadoras)
            {
                if(loc.Nome == "Locadora Centro")
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1575", "Locadora Centro", "Carro", 0, "NBJ-4189", 15000, "Ford", "Fusion", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1576", "Locadora Centro", "Carro", 0, "MZI-4665", 40000, "BMW", "I8", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1577", "Locadora Centro", "Carro", 0, "MNI-9344", 30000, "Porsche", "Panamera", true));

                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1578", "Locadora Centro", "Avião", 1000, "", 0, "Boeing", "747", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1579", "Locadora Centro", "Avião", 1200, "", 0, "Boeing", "787", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1580", "Locadora Centro", "Avião", 8000, "", 0, "Airbus", "A320", false));
                }
            }
            foreach (Locadora loc in RedeLocadoras.Locadoras)
            {
                if (loc.Nome == "Locadora Yvete Dias")
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1581", "Locadora Yvete Dias", "Carro", 0, "JKL-6086", 10000, "Hyundai", "Veloster", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1582", "Locadora Yvete Dias", "Carro", 0, "KZJ-5452", 280000, "Wolkswagem", "Gol Mexido", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1583", "Locadora Yvete Dias", "Carro", 0, "HVW-9099", 36000, "Wolkswagem", "Savero Rebaixada", true));

                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1584", "Locadora Yvete Dias", "Avião", 1400, "", 0, "Boeing", "737", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1585", "Locadora Yvete Dias", "Avião", 1800, "", 0, "Boeing", "720", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1586", "Locadora Yvete Dias", "Avião", 16000, "", 0, "Airbus", "A319", false));
                }
            }               
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
                    ListarVeiculosDisponíveis();
                    break;
                case 6:
                    ListarCarrosDisponíveis();
                    break;
                case 7:
                    ListaAviõesDisponíveis();
                    break;
                case 8:
                    ListarTodosOsVeiculos();
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
            string LocadoraBackup = LocadoraSelecionada;
            LocadoraSelecionada = "";
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
                    Console.WriteLine($"{Selecionar} foi selecionada!");
                }
            }
            if(LocadoraSelecionada == "")
            {
                Console.WriteLine($"{Selecionar} não foi encontrado na base de dados");
                LocadoraSelecionada = LocadoraBackup;
            }
        }
        public static void ListarVeiculosDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            { 
            foreach (Locadora locadora in RedeLocadoras.Locadoras)
            {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarVeiculosDisponiveis(LocadoraSelecionada);
                    }              
            }
            }
        }
        public static void ListaAviõesDisponíveis()
        {
            foreach (Locadora locadora in RedeLocadoras.Locadoras)
            {
                if (LocadoraSelecionada == "")
                {
                    Console.WriteLine("Selecione uma locadora primeiro");
                }
                else
                {
                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarAviõesDisponiveis(locadora);
                    }
                }
            }
        }
        public static void ListarCarrosDisponíveis()
        {
            foreach (Locadora locadora in RedeLocadoras.Locadoras)
            {
                if (LocadoraSelecionada == "")
                {
                    Console.WriteLine("Selecione uma locadora primeiro");
                }
                else
                {
                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarCarrosDisponiveis(locadora);
                    }
                }
            }
        }
        public static void ListarTodosOsVeiculos()
        {

            foreach (Locadora locadora in RedeLocadoras.Locadoras)
            {
                if (LocadoraSelecionada == "")
                {
                    Console.WriteLine("Selecione uma locadora primeiro");
                }
                else
                {
                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarTodosOsVeículos(LocadoraSelecionada);
                    }
                }
            }
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
