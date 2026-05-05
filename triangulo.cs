using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a._3exercicio_triangulo
{
    internal class triangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;

        }
        public double perimetro()
        {
            return 2 * Altura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
