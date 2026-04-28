using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anna2A
{
    internal class Program
    {
        static void Main(string[] args)

      {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("dados do primeiro funcionario:");
            Console.Write("nome: ");
            f1.nome=Console.ReadLine();
            Console.Write("Salário:");
            f1.salario =double.Parse(Console.ReadLine());

            Console.WriteLine("dados do segundo funcionario:");
            Console.Write("nome");
            f2.nome=Console.ReadLine();
            Console.Write("Salario:");
            f2.Salario=double.Parse(Console.ReadLine());

            double Salario_media =(f1.Salario + f2 salario) / 2.0;
            Console.WriteLine("salario medio="+Salario_media);

            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anna2A
{
    internal class Funcionario
    {
        public string nome;
        public double Salario;
    }
}


