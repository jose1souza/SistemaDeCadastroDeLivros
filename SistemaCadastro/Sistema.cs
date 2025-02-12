using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }



        private void btnBusca_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            listaAutor();
            LimpaCampos();
            listaLivros();
         
        }
        public void listaAutor()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaAutor();
            cbAutor.DataSource = tabelaDados;
            cbAutor.DisplayMember = "nome";
            cbAutor.ValueMember = "idautor";
        }

        void listaLivros()
        {

            ConectaBanco con = new ConectaBanco();
            dgLivros.DataSource = con.listaLivro();
        }



        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgLivros.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("titulo like '%{0}%'", txtBusca.Text);
  
        }

       private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
           


        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
                
        }

        void LimpaCampos()
        {
            txttitulo.Clear();
            txteditora.Clear();
            txtedicao.Clear();
            txtanoPublicacao.Clear();
            txtnumeroPaginas.Clear();
            cbAutor.Text = "";
            txttitulo.Focus();
        }

        public void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Livros novoLivro = new Livros();
            novoLivro.titulo = txttitulo.Text; 
            novoLivro.editora = txteditora.Text;
            novoLivro.edicao = Convert.ToInt32(txtedicao.Text);
            novoLivro.anoPublicacao = Convert.ToInt32(txtanoPublicacao.Text);
            novoLivro.numeroPaginas = Convert.ToInt32(txtnumeroPaginas.Text);
            novoLivro.autor = Convert.ToInt32(cbAutor.SelectedValue.ToString());
            bool retorno = con.insereLivro(novoLivro);
            if(retorno == true)
            {
                MessageBox.Show("Inserido com sucesso"); 
            }
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }

            LimpaCampos();
            listaLivros();

        }

        public void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtanoPublicacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txteditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int linha = dgLivros.CurrentRow.Index;
            int id = Convert.ToInt32(dgLivros.Rows[linha].Cells[0].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Livro", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaLivro(id);
                if (retorno == true)
                {
                    MessageBox.Show("Livro excluido com sucesso!");
                    listaLivros();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
            listaLivros();
        }

        private void dgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabAlterar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtedicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabRegistrar2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.insereAutor(txtnome.Text);
                if (retorno)
                {
                    MessageBox.Show("Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show(con.mensagem);
                }
                txtnome.Clear();
                txtnome.Focus();
                listaAutor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAdicionar;
        }
    }
}
