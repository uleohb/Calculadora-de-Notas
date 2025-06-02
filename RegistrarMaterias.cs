using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraUNIP
{
    


    class RegistrarMateria
    {
        public static void AdicionarMateria()
        {
            try
            {
                Titulo.ExibirTitulo("Registro de Matérias");
                Console.Write("Digite a matéria que deseja adicionar: ");
                string nomeMateria = Console.ReadLine()!;

                if (!ListaDicionario.registrarMaterias.ContainsKey(nomeMateria))
                {
                    ListaDicionario.registrarMaterias.Add(nomeMateria, new List<double>());
                    Console.WriteLine($"\nA matéria {nomeMateria} foi adicionada.");
                    Thread.Sleep(2500);
                    Console.Clear();

                    OpcoesMenu.ExibirOpcoesMenu();
                }
                else
                {
                    Console.WriteLine($"\nA matéria {nomeMateria} já existe.");
                    OpcoesMenu.ExibirOpcoesMenu();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(String.Format("Erro: {0}", ex.Message));
            }
           
                
        }
    }
}
