using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Avião
    {
        private float _horasVoo;

        public float HorasVoo { get => _horasVoo; set => _horasVoo = value; }

        public Avião(float horasVoo)
        {
            HorasVoo = horasVoo;

        }


    }
}
