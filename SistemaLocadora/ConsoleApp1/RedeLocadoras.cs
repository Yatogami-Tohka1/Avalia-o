using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RedeLocadoras
    {
        private string _nome;
        private List<Cliente> _clientes;
        private List<Locadora> _locadoras;

        public string Nome { get => _nome; set => _nome = value; }
        public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }
        public List<Locadora> Locadoras { get => _locadoras; set => _locadoras = value; }

        public static void AdicionarLocadora(Locadora loc)
        {
            ConsoleLocadoras.CriarLocadora();
        }
        public static bool RemoverLocadora(Locadora loc)
        {
            return true;
        }
    }
}
