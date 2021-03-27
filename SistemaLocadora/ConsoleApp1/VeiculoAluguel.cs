using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VeiculoAluguel
    {
        private string _id;
        private string _marca;
        private string _modelo;
        private bool _alugado;

        public string Id { get => _id; set => _id = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public bool Alugado { get => _alugado; set => _alugado = value; }


    }

    public class Avião
    {
        private float _horasVoo;

        public float HorasVoo { get => _horasVoo; set => _horasVoo = value; }

        public Avião(float horasVoo)
        {
            HorasVoo = horasVoo;

        }


    }

    public class Carro
    {
        string _placa;
        float _quilometragem;

        public string Placa { get => _placa; private set => _placa = value; }
        public float Quilometragem { get => _quilometragem; private set => _quilometragem = value; }

        public Carro(string placa, float quilometragem)
        {
            Placa = placa;
            Quilometragem = quilometragem;

        }




    }
}
