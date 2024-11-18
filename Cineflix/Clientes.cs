using Cineflix;
using Roupabox;
using System;
using System.Collections.Generic;


namespace Roupabox

{
   
    internal class Clientes
    {
        
        public void cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o Nome Completo do Cliente: ");
            string nomeCli = Console.ReadLine();
        
            Console.WriteLine("\nDigite o CPF do Cliente: ");
            long cpfCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Telefone do Cliente: ");
            long telCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a idade do Cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o E-mail do Cliente: ");
            string emailCli = Console.ReadLine();

            Console.WriteLine("\nDigite o Sexo do Cliente: ");
            string sexoCli = Console.ReadLine();

            Console.WriteLine("\nDigite a Rua / Avenida do Clinte: ");
            string ruaCli = Console.ReadLine();

            Console.WriteLine("\nDigite o complemento da rua caso tenha: ");
            string compCli = Console.ReadLine();

            Console.WriteLine("\nDigite o número da casa: ");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Bairro: ");
            string bairroCli = Console.ReadLine();

            Console.WriteLine("\nDigite a Cidade do cliente: ");
            string cidCli = Console.ReadLine();

            Console.WriteLine("\nDigite o estado do cliente: ");
            string estCli = Console.ReadLine();

            Console.WriteLine("\nDigite o CEP do cliente: ");
            long cepCli = long.Parse(Console.ReadLine());


            Console.WriteLine("\nCliente cadastrado com sucesso!!!!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal!");
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

