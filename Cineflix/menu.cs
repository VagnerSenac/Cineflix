using Cineflix;
using Roupabox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Roupabox
{
    internal class ExibirMenu
    {
        //Produtos varPro = new Produtos();
        public void Menu(Produtos varPro)
        {
            List<ProdutoCad> listaP = new List<ProdutoCad>();
            while (true) { 
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("Digite 1 Cadastro de Clientes");
            Console.WriteLine("Digite 2 Listar Clientes");
            Console.WriteLine("Digite 3 Cadastro de Produtos");
            Console.WriteLine("Digite 4 Listar Produto");

            Console.WriteLine("\nDigite a opção escolhida:");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());

            switch (opcaoEscolhidaNumero)
            {
                case 1:

                    Clientes varCli = new Clientes();
                    varCli.cadCliente();

                    break;

                case 2:
                 

                    break;


                case 3:

                    varPro.cadProduto();
                    break;


                case 4:
                    varPro.ListarProdutos();


                    break;

                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
███████╗██╗░░░██╗██╗
██╔════╝██║░░░██║██║
█████╗░░██║░░░██║██║
██╔══╝░░██║░░░██║██║
██║░░░░░╚██████╔╝██║
╚═╝░░░░░░╚═════╝░╚═╝");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                if(opcaoEscolhidaNumero == 0)
                {
                    break;
                }
            }

        }
    }
}
