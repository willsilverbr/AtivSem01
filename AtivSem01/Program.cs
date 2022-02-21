using System;
namespace AtivSem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcoes funcoes = new Funcoes();
            int menu;
            Console.WriteLine("Menu para Chamar as Funções: " +
                              "\n 1- Somar Valores da Matriz"+
                              "\n 2- Verificar o Maior Número: ");
            menu = Convert.ToInt32(Console.ReadLine());

            try
                //Verificação de Erro para todas as Funções
            {
                switch (menu)
                {

                    case 1: //Chamada para a função que Soma a Matriz

                        funcoes.matrizSomatoria();
                        break;

                    case 2: //Chama a Função que retorna o maior númerico
                        funcoes.MaiorNumero();
                        break;

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ex: "+ex.Message);
            }
               
 
        }
    }
}
