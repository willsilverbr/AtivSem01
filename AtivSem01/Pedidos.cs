using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    sealed class Pedidos : Cadastro
    {
        //4.5) As Classes Clientes e Pedidos 
        //    devem preencher a propriedade Conexão a partir de seus construtores
        public int idPedido { get; set; }
        public string infoProduto { get; set; }
    }
}
