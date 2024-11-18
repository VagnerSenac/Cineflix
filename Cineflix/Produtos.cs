using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Cineflix
{

    internal class Produtos
    {

        

       

        public void cadProduto(List<ProdutoCad> listaProdutos)
        {

            if (listaProdutos.Equals(null))
            {
                listaProdutos = new List<ProdutoCad>();
            }
            Console.Clear();
            Console.WriteLine("Registro de Produto");
            Console.WriteLine("\nDigite o nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            var Produto = new ProdutoCad(nomeProduto);

            Console.WriteLine("\nDigite a descrição do Produto: ");
            string descricaoProduto = Console.ReadLine();
            Produto.descricaoProduto = descricaoProduto;

            Console.WriteLine("\nDigite o preço do Produto: ");
            string precoProdutos = Console.ReadLine();
            Produto.precoProdutos = double.Parse(precoProdutos);

            Console.WriteLine("\nDigite a quantidade do Produto: ");
            string quantidadeProduto = Console.ReadLine();
            Produto.Quantidade = int.Parse(quantidadeProduto);

            listaProdutos.Add(Produto);

            Console.WriteLine($"O Produto foi Cadastrado");
            
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, " + $"Descrição: {produto.precoProdutos}, " + $"Preço: {produto.precoProdutos}, " + $"Quantidade: {produto.Quantidade}, ");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            Produtos varPro = new Produtos();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro);

        }
        public void ListarProdutos()
        {

            Console.Clear();
            Console.WriteLine("Lista de Produto");

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, " + $"Descrição: {produto.precoProdutos}, " + $"Preço: {produto.precoProdutos}, " + $"Quantidade: {produto.Quantidade}, ");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();
            
            Produtos varPro = new Produtos();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro);
        }
    }
}
