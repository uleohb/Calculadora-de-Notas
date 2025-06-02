using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUNIP
{
    class PreencherNota
    {
       
        
        public static double PreencherMateria()
        {
            try
            {
                Titulo.ExibirTitulo("Calculo de notas");
                Console.Write("Digite a matéria para realizar o calculo: ");
                string nomeMateria = Console.ReadLine()!;

                if (ListaDicionario.registrarMaterias.ContainsKey(nomeMateria))
                {
                    CalcularNota.ResultadoMedia();
                    Thread.Sleep(2000);
                    Console.Clear();
                    OpcoesMenu.ExibirOpcoesMenu();
                }
                else
                {
                    Console.WriteLine($"A matéria {nomeMateria} não esta registrada.");
                    Console.Clear();
                    Thread.Sleep(1500);
                    PreencherMateria();
                }
                return 0.0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro: {0}", ex.Message));
                return -1;
            } 
        }            
    }
}
