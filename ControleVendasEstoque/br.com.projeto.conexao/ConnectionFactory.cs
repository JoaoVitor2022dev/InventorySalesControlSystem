using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasEstoque.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
      public MySqlConnection GetConnection() 
      {

            String conecxao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conecxao);
      }
    }
}
