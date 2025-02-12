using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace SistemaCadastro
{
    public class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=banco_siscadastro");
        public string mensagem;

        public bool insereLivro(Livros novoLivro)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereLivro", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("titulo", novoLivro.titulo);
                cmd.Parameters.AddWithValue("editora", novoLivro.editora);
                cmd.Parameters.AddWithValue("edicao", novoLivro.edicao);
                cmd.Parameters.AddWithValue("anoPublicacao", novoLivro.anoPublicacao);
                cmd.Parameters.AddWithValue("numeroPaginas", novoLivro.numeroPaginas);
                cmd.Parameters.AddWithValue("fk_idAutor", novoLivro.autor);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        } // fim do insereLivro

        public bool insereAutor(string nome)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereAutor", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        } // fim do insereAutor 
        public DataTable listaAutor()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("sp_listaAutor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim listaAutor
        public DataTable listaLivro()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaLivros", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
    } // fim da classe

    public bool deletaLivro(int idRemovelivro)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeLivro", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idlivro", idRemovelivro);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaLivro

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("sp_login", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
