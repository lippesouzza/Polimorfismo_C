using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2.Src
{
    class Triangulo : Area, ITriangulo
    {
        public Triangulo(double _base, double _altura) : base(_base, _altura)
        {

        }

        public double AreaTriangulo()
        {
            return (_Base * _Altura) / 2;
        }

        public override string ToString()
        {
            return $"Área do triangulo: {AreaTriangulo()}";
        }
    }
}