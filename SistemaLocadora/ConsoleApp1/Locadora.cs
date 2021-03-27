using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Locadora
    {
        private string _nome;
        private string _endereço;
        private List<VeiculoAluguel> _VeiculosAluguel;
        private List<Aluguel> _AlugueisAtuais;

        public string Endereço { get => _endereço; set => _endereço = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public List<VeiculoAluguel> VeiculosAluguel { get => _VeiculosAluguel; set => _VeiculosAluguel = value; }
        public List<Aluguel> AlugueisAtuais { get => _AlugueisAtuais; set => _AlugueisAtuais = value; }

        public void AdicionarVeiculoAluguel (VeiculoAluguel a)
        {

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
