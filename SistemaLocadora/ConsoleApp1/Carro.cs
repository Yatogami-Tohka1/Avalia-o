using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Carro
    {
        private string _placa;
        private float _quilometragem;
        public string Placa { get => _placa; set => _placa = value; }
        public float Quilometragem { get => _quilometragem; set => _quilometragem = value; }
    }
}
