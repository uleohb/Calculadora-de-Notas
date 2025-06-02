using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUNIP
{
    class VisualizarMedia
    {
        public static void VisualizacaoDeMedias() 
        {

            Titulo.ExibirTitulo("Médias do Semestre");

            if (ListaDicionario.registrarMaterias.Count == 0)
            {
                Console.WriteLine("Nenhuma matéria registrada.");
            }
            else
            {
                foreach (var materia in ListaDicionario.registrarMaterias)
                {
                    string nomeMateria = materia.Key;
                    List<double> notas = materia.Value;

                    if (notas.Count > 0)
                    {
                        double notaMedia = notas.Average();
                        Console.WriteLine($"{nomeMateria} : {notaMedia:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{nomeMateria} : Sem notas registradas");
                    }
                }
            }

            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            OpcoesMenu.ExibirOpcoesMenu();
        }

    }
    
}
