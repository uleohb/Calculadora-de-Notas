using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUNIP
{
    class CalcularNota
    {
        public static double nota, nota1, nota2, notaPim, notaMedia;

        public static double ResultadoMedia()
        {
            try
            {
                nota1 = InformarNota("Informe a nota 1: ");
                nota2 = InformarNota("\nInforme a nota 2: ");
                notaPim = InformarNota("\nInforme a nota do Pim: ");

                double notaMedia = ((nota1 * 0.4) + (nota2 * 0.4) + (notaPim * 0.2));


                if (notaMedia >= 7)
                {
                    Console.WriteLine($"Média: {notaMedia} - Aprovado");
                }
                else
                {
                    Console.WriteLine($"Média: {notaMedia} - Reprovado");
                }

                return notaMedia;
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro: {0}", ex.Message));

                return -1;
            }
            
        }
       
    
        private static double InformarNota(string inputLabel)
        {
            try
            {
                Console.WriteLine(inputLabel);

                string input = Console.ReadLine()!;

                if (!String.IsNullOrEmpty(input))
                {
                    nota = Convert.ToDouble(input);
                    return nota;
                }
                else
                {
                    Console.WriteLine("Favor digitar uma nota de 0 à 10");

                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro: {0}", ex.Message));
                return -1;
            }          
        }
    }
}
