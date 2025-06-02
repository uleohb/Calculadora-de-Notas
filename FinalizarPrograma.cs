using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUNIP
{
    class FinalizarPrograma
    {
        public static void Encerrar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Finalizando o programa...");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {

                Console.WriteLine(String.Format("Erro: {0}", ex.Message));
            }
           
        }
    }
}
