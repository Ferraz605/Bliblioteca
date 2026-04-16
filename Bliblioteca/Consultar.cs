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
    public partial class Consultar : Form
    {
        DAOAutor dao;

        public Consultar()
        {
            this.dao = new DAOAutor();
            ChamarMetodo(dataGridView1); // CONFIGURAR TODA A ESTRUTURA 
    
        } // FIM DO CONSTRUTOR CONSULTAR


        //CHAMAR METODO
        public void ChamarMetodo(DataGridView dataGrid) {

            InitializeComponent();
            ConfigurarDataGrid(dataGrid); // Configuro a estrutura
            NomeColunas(dataGrid); // Configuro Nomes
            AdicionarDados(dataGrid); // Adiciono Dados

        }// FIM DO METODO


        //NOME COLUNAS
        public void NomeColunas(DataGridView dataGrid) {
        
            dataGrid.Columns[0].Name = "Código";
            dataGrid.Columns[1].Name = "Nome";
            dataGrid.Columns[2].Name = "Genero";
            dataGrid.Columns[3].Name = "Endereço";
        } // FIM DO METODO

        // DEFINIR ESTRUTURA DA TABELA

        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false; // Não permito que o usuario adicione linha
            dataGrid.AllowUserToDeleteRows = false; // Não deleta linhas
            dataGrid.AllowUserToResizeColumns = false;  
            dataGrid.AllowUserToResizeRows = false;

            dataGrid.ColumnCount = 4;
        } // FIm do CONFIGURAR

        public void AdicionarDados(DataGridView dataGrid) { 
        
            // Primeira coisa sera preencher o vetor
            this.dao.PreencherVetor();

            for(int i = 0; i < this.dao.contar; i++)
            {
                dataGrid.Rows.Add(this.dao.codigo[i], this.dao.nome[i], this.dao.genero[i], this.dao.endereco[i]);
            }
        } // FIM DO ADICIONARDADOS


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } // FIM DA  CLASSE
} // FIM DO PROJETO
