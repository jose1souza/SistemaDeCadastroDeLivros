using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BtnConfirmaLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            if (conecta.verifica(txtUserLogin.Text, txtSenhaLogin.Text) == true)
            {
                Sistema sistema = new Sistema();
                this.Hide();
                sistema.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta " + conecta.mensagem);
                
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
