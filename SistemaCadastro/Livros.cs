using System;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class Livros
    {
        public string titulo;
        public string editora;
        public int edicao;
        public int anoPublicacao;
        public int numeroPaginas;
        public int autor;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Editora { get => editora; set => editora = value; }
        public int Edicao { get => edicao; set => edicao = value; }
        public int AnoPublicacao { get => anoPublicacao; set => anoPublicacao = value; }
        public int NumeroPaginas { get => numeroPaginas; set => numeroPaginas = value; }
        public int Autor { get => autor; set => autor = value; }
    }
    /* public class Autor 
    {
        public string nome;
        public string Nome
        {
            get => nome; set => nome = value;
        }
    } */
}
