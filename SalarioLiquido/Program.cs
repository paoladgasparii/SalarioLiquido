using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário bruto do funcionário: ");
            double sbruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do vale alimentação: ");
            double alimentacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de dependentes: ");
            double dependentes = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por dependente: ");
            double valordep = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas extras: ");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora extra: ");
            double valorhoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do INSS: ");
            double inss = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double resultado = sbruto + alimentacao + (dependentes * valordep) + (horas * valorhoras) - inss - irpf;

            Console.WriteLine("O salário líquido do funcionário é: R$" + resultado);
            Console.ReadKey();
        }
    }
}
