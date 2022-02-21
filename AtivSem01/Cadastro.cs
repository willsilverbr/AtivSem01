using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtivSem01
{
    abstract class Cadastro : IOperacoesBD
    {
       protected string Conexao { get; set; }
    }
}
