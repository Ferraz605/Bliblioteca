using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms; // importando a biblioteca da tela forms

namespace Bliblioteca
{
    internal class Program
    {
            [STAThread]
        static void Main(string[] args)
        {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Menu());
        } // fim da classe main
    } // fim da classe
} // fim do projeto
