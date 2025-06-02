using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraUNIP;

namespace CalculadoraUNIP
{
    class OpcoesMenu
    {

        public static double ExibirOpcoesMenu()
        {
            try
            {
                Titulo.ExibirTitulo("Calculadora UNIP");
                Console.WriteLine("\n1- Registrar matérias");
                Console.WriteLine("2- Vizualizar matérias do semestre");
                Console.WriteLine("3- Calcular média");
                Console.WriteLine("0- Finalizar");


                Console.Write("\nEscolha uma opção: ");
                double opcaoEscolhida = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Thread.Sleep(2000);

                switch (opcaoEscolhida)
                {
                    case 1:
                        RegistrarMateria.AdicionarMateria();
                        break;

                    case 2:
                        VisualizarMaterias.MostrarMaterias();
                        break;

                    case 3:
                        PreencherNota.PreencherMateria();
                        break;

                    case 0:
                        FinalizarPrograma.Encerrar();
                        
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        Console.Clear();
                        ExibirOpcoesMenu();
                        break;
                }

                return opcaoEscolhida;
            }
            

            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro: {0}", ex.Message));

                return -1;
            }
            
        }
    }
}
