using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bliblioteca
{
    public partial class Cadastrar: Form
    {

        DAOAutor autor;

        public Cadastrar()
        {
            InitializeComponent();
            // INSERIR
            this.autor = new DAOAutor();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        } // FIM DO NOME

        private void Genero_Click(object sender, EventArgs e)
        {

        } // FIM DO GENERO

        private void label5_Click(object sender, EventArgs e)
        {

        } // FIM DO ENDERECO

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Preencha os Campos");
            }
            else
            {
            string nome = textBox1.Text;
            string genero = textBox2.Text;
            string endereco = textBox3.Text;
            // INSERIR DENTRO DO BANCO
            this.autor.Inserir(nome, genero, endereco);
            // limpar os campos
            LimparCampos();
            }


        }// FIM DO CADASTRAR

        // LIMPAR CAMPOS

        public void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } // FIM DO NOME

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } // FIM DO GENERO

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// FIM DO ENDERECO
    }
}
