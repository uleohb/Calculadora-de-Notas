using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUNIP
{
    class VisualizarMaterias
    {
        
        public static void MostrarMaterias()
        {
            ListaDicionario.registrarMaterias.TryAdd("Programação Orientada a Objetos", new List<double> ());
            ListaDicionario.registrarMaterias.TryAdd("Banco de Dados", new List<double> ());
            ListaDicionario.registrarMaterias.TryAdd("Engenharia de Software", new List<double> ());
            try
            {
                Titulo.ExibirTitulo("Vizualização de Matérias do Semestre");

                foreach (string materia in ListaDicionario.registrarMaterias.Keys)
                {
                    Console.WriteLine($"Matérias do Semestre: {materia}");
                }
                Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                Thread.Sleep(1500);
                OpcoesMenu.ExibirOpcoesMenu();

            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro: {0}", ex.Message));
            }         
        }
    }
}
