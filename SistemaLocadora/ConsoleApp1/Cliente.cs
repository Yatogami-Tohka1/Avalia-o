using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cliente
    {
        private string _nome;
        private string _cpf;
        private List<Aluguel> _alugueis;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public List<Aluguel> Alugueis { get => _alugueis; set => _alugueis = value; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public bool Alugar(VeiculoAluguel v)
        {
            return true;
        }
    }
}
