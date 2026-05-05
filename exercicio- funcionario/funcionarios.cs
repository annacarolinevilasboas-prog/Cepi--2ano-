using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using.System.Globalization

using System.Globalization;

namespace exercicio_funcionario
{
    internal class funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {

            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }
        public override string ToString()
        {
            return Nome
             + ",R$"
             + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
