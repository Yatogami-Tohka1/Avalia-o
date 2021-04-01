using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VeiculoAluguel
    {
        public VeiculoAluguel(string id, string marca, string modelo, bool alugado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Alugado = alugado;
        }

        private string _id;
        private string _marca;
        private string _modelo;
        private bool _alugado;

        public string Id { get => _id; set => _id = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public bool Alugado { get => _alugado; set => _alugado = value; }


    }
}
