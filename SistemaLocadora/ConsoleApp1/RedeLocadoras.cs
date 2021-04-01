using System.Collections.Generic;
using System;

namespace ConsoleApp1
{
    class RedeLocadoras
    {
        private string _nome;
        private List<Cliente> _clientes = new List<Cliente>();
        private static List<Locadora> _locadoras = new List<Locadora>();

        public string Nome { get => _nome; set => _nome = value; }
        public static List<Locadora> Locadoras { get => _locadoras; private set => _locadoras = value; }
        public List<Cliente> Clientes { get => _clientes; private set => _clientes = value; }

        public static void AdicionarLocadora(Locadora loc)
        {
            Locadoras.Add(loc);
        }
        public static bool RemoverLocadora(Locadora loc)
        {           
            return true;
        }
        public void AdicionarCliente(Cliente c)
        {
            Clientes.Add(c);
        }
        public static void ListarLocadoras()
        {
            foreach(Locadora loc in Locadoras)
            {
                Console.WriteLine($"Nome: {loc.Nome} | Endereço: {loc.Endereço}");
            }
        }
    }
}
