using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class ConsoleLocadoras
    {
       public static void Main()
        {
            int c = 0;
            Carro FordHXJ1727 = new Carro("HXJ-1727", 0);
            Carro ToyotaHLD7129 = new Carro("HLD-7129", 2000);
            Carro AudiHZE8769 = new Carro("HZE-8769", 30000);
            Carro ChevroletHQN1388 = new Carro("HQN-1388", 10000);
            Carro HondaJIV0767 = new Carro("JIV-0767", 3000);

            Avião Boeing747 = new Avião(3000);
            Avião Jato = new Avião(10000);
            Avião Ultrassônico = new Avião(100);
            while (c == 0)
            {
                MostrarMenu();
            }           
        }
        
        
       public static void MostrarMenu()
        {
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
        }
        public static void SelecionarLocadora()
        {

        }
        public static void ListarVeiculosDisponíveis(Locadora loc)
        {

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
