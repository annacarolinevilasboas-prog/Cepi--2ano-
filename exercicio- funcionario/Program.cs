using exercicio_funcionario;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionarios
{
    internal class program
        atic void Main(string[] args)
    {
       funcionario func = new funcionario();

        Console.Write("None:");
        func.Nome = Console.ReadLine();
        Console.Write("Salario Bruto:");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto:");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("");
        Console.WriteLine("Funcionario;" + func);

        Console.WriteLine("");
        Console.Write("Deseja aumwntar o salario em qual porcentagem:");
        double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        func.AumentarSalario(porcent);

        Console.WriteLine("");
        Console.WriteLine("Dados atualizados:"+func);


    {
        
        {
           
            {
                
          
                
 
            }
   


        
        {
        }
    }
}
