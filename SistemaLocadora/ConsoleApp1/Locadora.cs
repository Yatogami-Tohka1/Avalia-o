using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Locadora
    {
        private string _nome;
        private string _endereço;
        private static List<VeiculoAluguel> _veiculosAluguel = new List<VeiculoAluguel>();
        private List<Aluguel> _AlugueisAtuais = new List<Aluguel>();

        public string Endereço { get => _endereço; set => _endereço = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public static List<VeiculoAluguel> VeiculosAluguel { get => _veiculosAluguel; set => _veiculosAluguel = value; }
        public List<Aluguel> AlugueisAtuais { get => _AlugueisAtuais; set => _AlugueisAtuais = value; }

        public Locadora (string nome, string endereço)
        {
            Nome = nome;
            Endereço = endereço;
        }


        public void AdicionarVeiculoAluguel (VeiculoAluguel a)
        {
            VeiculosAluguel.Add(a);
        }
        public bool RemoverVeiculoAluguel(VeiculoAluguel a)
        {
            return true;
        }
        public bool EfetuarAluguel(VeiculoAluguel v, Cliente c)
        {
            return true;
        }
        public float FinalizarAluguel(Aluguel a)
        {
            return 1.0f;
        }

        

        




    }
}
