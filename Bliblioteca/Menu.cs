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
    public partial class Menu : Form
    {

        Cadastrar cad;
        Consultar con;

        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 

        private void BTN_Cadastrar_Click(object sender, EventArgs e)
        {
            cad = new Cadastrar();
            cad.ShowDialog();

        } // BOTAO CADASTRAR

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Consultar_Click(object sender, EventArgs e)
        {
            con = new Consultar();  
            con.ShowDialog();            

        } // BOTAO CONSULTAR
    } // CLASSE MENU
} // PROJETO BIBLIOTECA 
