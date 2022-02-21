using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AtivSem01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             *Dan, bom dia! 
             *Infelizmente (Ainda) não estou conseguindo resolver as funcões:
             *Inserir/Deletar/Pesquisar/Alterar
             *Desculpe!
             */

            //Variaveis de Controle para continuar ou sair do sistema (do while)

            char opcao;
            bool sair;

            do
            {
                //Inicio do programa

            Funcoes funcoes = new Funcoes();
            int menu;
            Console.Clear();
            Console.WriteLine("Menu para Chamar as Funções: " +
                              "\n 1- Somar Valores da Matriz"+
                              "\n 2- Verificar o Maior Número: "+
                              "\n 3- Instanciar um novo usuario: "+
                              "\n 4- Instanciar um novo pedido: ");
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

                        case 3: //Instanciar um novo usuário
                                //Incluindo alguns Clientes (teste) aos contrutores
                                Console.Clear();    
                                List<Clientes> clientes = new List<Clientes>();
                                clientes.Add(new Clientes() { id = 1, nome = "William" });
                                clientes.Add(new Clientes() { id = 2, nome = "Ana" });
                                clientes.Add(new Clientes() { id = 3, nome = "Leonardo" });
                                Console.WriteLine("Usuarios Salvo com sucesso! ");
                            
                            //Não é Possivel instanciare depois serializar a classe, mas não funcionou
                            //porque a classe é protegida:
                            //Console.WriteLine("Informe o nome do usuario: ");
                            //clientes.nome = Console.ReadLine();
                            //Console.WriteLine("Informe o Id do usuario ");
                            //clientes.id = Convert.ToInt32(Console.ReadLine());
                            ////Console.WriteLine("Informe o e-mail do usuario do usuario: ");
                            ////clientes.email = Console.ReadLine();

                            //XmlSerializer serializador = new XmlSerializer(typeof(Clientes));

                            //StreamWriter stream = new StreamWriter("C:\\Users\\wills\\source\\repos\\AtivSem01\\Arquivor\01_SerializarXML.xml");
                            //serializador.Serialize(stream, clientes);
                            break;

                        case 4:
                            Console.Clear();
                            //Incluindo alguns (teste) Clientes aos contrutores
                            List<Pedidos> pedidos = new List<Pedidos>();
                            pedidos.Add(new Pedidos() { idPedido = 1, infoProduto = "Livro" });
                            pedidos.Add(new Pedidos() { idPedido = 2, infoProduto = "Celular" });
                            pedidos.Add(new Pedidos() { idPedido = 3, infoProduto = "Fone de ouvido" });
                            Console.WriteLine("Pedidos Salvo com sucesso!");
                            break;

                        
                 }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ex: "+ex.Message);
            }
               
                //Verificar se o usuário deeja continuar no sistema
                Console.WriteLine("\nDeseja Sair do programa ?\n'S' para sim e 'N' para não");
                opcao = Convert.ToChar(Console.ReadLine());
                if (opcao == 'n' || opcao =='N')
                {
                    sair = true;
                }
                else
                {
                    sair = false; 
                }

            } while (sair != false);


            Console.WriteLine("Programa finalizado com sucesso. Obrigado!");

        }
    }
}
