using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor gasto em comida: ");
            double valorComida = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com bebida: ");
            double valorBebida = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com sobremesa: ");
            double valorSobremesa = double.Parse(Console.ReadLine());

            double totalGasto = valorComida + valorBebida + valorSobremesa;

            Console.WriteLine("O Valor total gasto foi: " + totalGasto.ToString("C"));

            Console.Write("Informe o número de pessoas: ");
            int qdtPessoas = int.Parse(Console.ReadLine());

            double totalPorPessoa = totalGasto / qdtPessoas;

            Console.WriteLine("Total gasto por pessoa foi: " + totalPorPessoa.ToString("C"));

            Console.Write("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();

                
                
                
                
                
                
                
                
        }
    }
}
