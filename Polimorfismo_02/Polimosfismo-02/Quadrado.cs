using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2.Src
{
    class Quadrado : Area, IQuadrado
    {

        public Quadrado(double _lado) : base(_lado)
        {
        }

        public double AreaQuadrado()
        {
            return _Lado * _Lado;
        }

        public override string ToString()
        {
            return $"Área do quadrado: {AreaQuadrado()}";
        }
    }
}