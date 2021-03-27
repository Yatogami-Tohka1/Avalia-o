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
       
        Locadora Locadora = new Locadora();
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
