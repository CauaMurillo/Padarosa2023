using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa2023.Classes
{
    public class OrdemComanda
    {
        public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdResponsavel { get; set; }
        public DateTime DataAdicionado { get; set; }
        public int Situacao { get; set; }

        public bool NovoLancamento()
        {
            string comando = "INSERT INTO ordens_comandas( id_ficha, id_produto, quantidade, id_resp)" +
                "VALUES (@id_ficha,@id_produto,@quantidade,@id_resp)";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
            cmd.Parameters.AddWithValue("@id_produto", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", IdResponsavel);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
    }
}

