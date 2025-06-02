using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUNIP
{

    class Titulo
    {
         
        public static string ExibirTitulo(string titulo) //Função com parâmetro para preencher o texto do titulo
        {
            int quantidadeDeLetras = titulo.Length;
            string barra = string.Empty.PadLeft(quantidadeDeLetras, '-'); //A barra ter o mesmo tamanho que o titulo
            Console.WriteLine(barra);//-
            Console.WriteLine(titulo);//nome do titulo
            Console.WriteLine(barra);//-
            return titulo;
        }
    }
}
