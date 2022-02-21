using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AtivSem01
{
    abstract class Cadastro : IOperacoesBD
    {
       protected string Conexao { get; set; }
        //Desculpe. Nessa Parte fiquei na duvida se era para fazer uma string como exemplo
        //(como a de cima)

        // ou Realmente realizar a conexao no exemplo Abaixo: 

        //public string strConn;
        //public ConexaoBanco()
        //{
        //    InitializeComponent();
        //
        //    Parametros de conexão
        //    strConn = ("Data Source=Boson-PC\\SQLEXPRESS;Initial Catalog=db_Biblioteca;Integrated Security=true");
        //}

        //SqlConnection con = new SqlConnection(strConn);
        //abrindo conexao com o banco
        //Con.Open();
    }
}
