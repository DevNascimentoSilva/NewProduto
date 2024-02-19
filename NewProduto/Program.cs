using System;
using System.Globalization;

namespace NewProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto.");

            Console.WriteLine();
            Console.Write("Nome do Produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço do Produto: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade do Produto no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.Write("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine();

            Console.Write("Dados do Produto Atualizado: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produto a ser removido do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine();

            Console.Write("Dados atualizados: " + p);
            Console.WriteLine();
        }
    }
}
