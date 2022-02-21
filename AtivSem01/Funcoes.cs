using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtivSem01
{
    public class Funcoes
    {


        public int matrizSomatoria(int linhas = 0, int colunas = 0, int aux = 0, int resultadoSoma = 0)
        {
            Console.Clear();
            //Nessa parte recebemos a quantidade de linha e colunas que o usuário deseja
            Console.WriteLine("Digite a quantidade de linhas que você deseja inserir na Matriz: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas que você deseja inserir na Matriz: ");
            colunas = Convert.ToInt32(Console.ReadLine());

            //Nessa parte inicio a Matriz com os Valores definidos
            int[,] matriz = new int[linhas, colunas];

            //Esse For é referente a quantidade de linhas da matriz
            for (int i = 1; i <= linhas; i++)
            {
                Console.WriteLine("Essa é a linha " + i + "\n");

                //O For interno é referente a quantidade de colunas da matriz
                for (int j = 1; j <= colunas; j++)
                {
                    Console.WriteLine(i + "º linha " +
                                      ": Informe o valor da Coluna " + j);

                    //faço a captação do numero e jogo e guardo na variavel soma
                    aux = Convert.ToInt32(Console.ReadLine());
                    resultadoSoma += aux;

                }

            }

            Console.WriteLine("\n A o valor da soma total da matriz é: " + resultadoSoma);

            return resultadoSoma;

        }
        public double MaiorNumero()
        {
            Console.Clear();

            double numeroAtual;
            double maiorValor = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite o " + i + " valor:");
                numeroAtual = Convert.ToDouble(Console.ReadLine());
                if (numeroAtual >= maiorValor)
                {
                    maiorValor = numeroAtual;
                }
                else
                {
                    Console.WriteLine("Invalido! Serão verificados apenas números positivos.");
                }
                
            }
            Console.WriteLine("\n O maior valor é: " + maiorValor);

            return maiorValor;
        }
    }
}
