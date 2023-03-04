using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consorcio
{
    class Program
    {
        static void Main(string[] args)
        {

            int participantes;
            int j = 0;


            Console.WriteLine("insira o número de participantes: ");
            participantes = int.Parse(Console.ReadLine());

            string[,] dados = new string[participantes, participantes];

            for (int i = 0; i < participantes; i++)
            {


                

                Console.Write("Digite o nome do cliente para a posição [{0},{1}]: ", i, j);
                string nomeCliente = Console.ReadLine();

                Console.Write("Digite o número para o cliente {0}: ", nomeCliente);
                int numeroCliente = Convert.ToInt32(Console.ReadLine());

                dados[i, j] = $"{nomeCliente} ({numeroCliente})";
                j++;





            }



            //for (int i = 0; i < participantes; i++)
           // {
                
             //       Console.WriteLine(dados[i,i]);
                
           // }

            Console.ReadKey();

        }
    }
}
