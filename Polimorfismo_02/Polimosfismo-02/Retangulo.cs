using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2.Src
{
    class Retangulo : Area, IRetangulo
    {
        public Retangulo(double _base, double _altura) : base(_base, _altura)
        {
        }

        public double AreaRetangulo()
        {
            return _Base * _Altura;
        }
        public override string ToString()
        {
            return $"Área do retangulo: {AreaRetangulo()}";
        }
    }
}