using Cineflix;
using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roupabox
{
    internal class Program 
    {

        public List<ProdutoCad> listaProdutos = new List<ProdutoCad>();

        static void Main(string[] args)
        {
           

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            Produtos varPro = new Produtos();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro);
    
        }

    }
}
