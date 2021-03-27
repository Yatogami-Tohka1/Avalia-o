using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class ConsoleLocadoras
    {
       public static void Main()
        {
            MostrarMenu();
        }
       //TESTE
        Locadora LocadoraCentro = new Locadora("Locadora do Centro", "Avenida dos aviadores N°89");
        Cliente Cliente = new Cliente();
        
        
       public static void MostrarMenu()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n " +
                "      Sistema de Locadoras\n " +
                "\n" +
                "1 - Criar Locadora \n" +
                "2 - Remover Locadora\n" +
                "3 - SelecionarLocadora\n" +
                "4 - ListarVeiculosDisponiveis\n" +
                "5 - ListarCarrosDisponíveis\n" +
                "6 - ListarAviõesDisponíveis\n" +
                "7 - ListarTodosOsVeiculo\n" +
                "8 - CadastrarCliente\n" +
                "9 - DevolverVeículo\n" +
                "10 - Listar Alugueis\n" +
                "11 - ListarAlugueisCliente\n" +
                "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
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
                default:
                    break;
            }
        }
        public static void CriarLocadora()
        {

        }
        public static void RemoverLocadora()
        {

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
