using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Carro
    {
        string _placa;
        float _quilometragem;

        public string Placa { get => _placa; set => _placa = value; }
        public float Quilometragem { get => _quilometragem; set => _quilometragem = value; }

        public Carro(string placa, float quilometragem)
        {
            Placa = placa;
            Quilometragem = quilometragem;

        }


    }
}
