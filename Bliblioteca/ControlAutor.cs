using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliblioteca
{
    class ControlAutor
    {
        DAOAutor autor;
        public int opcao;

        public ControlAutor()
        {
            this.autor = new DAOAutor(); // Abrindo a conexão com o BD
        }// Fim do construtor

        // Mostrar MENU

        public void MostrarMenu()
        {
            Console.WriteLine("-------MENU--------\n\n " +
                "\n 0 Sair" +
                "\n 1 Cadastrar" +
                "\n 2 Consultar tudo" +
                "\n 3 Consultar por codigo" +
                "\n 4 Atualizar" +
                "\n 5 Excluir" +
                "\n Escolha uma das opções acima");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void ExecutarOperacao()
        {
            do
            {
                this.MostrarMenu(); // Mostrar opções disponiveis

                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Autor");
                        // Formulario de cadastro
                        Console.WriteLine("Informe o nome do autor: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o genero do autor: ");
                        string genero = Console.ReadLine();

                        Console.WriteLine("Informe o endereço do autor: ");
                        string endereco = Console.ReadLine();

                        // Inserir esses dados no banco
                        this.autor.Inserir(nome, genero, endereco);
                        break;
                    case 2:
                        Console.WriteLine("Consultar Tudo Autor");

                        // Chamar o metodo
                       Console.WriteLine(this.autor.ConsultarTudo());
                        break;
                    case 3:
                        Console.WriteLine("Consultar por codigo Autor");
                        // Pedir o codigo
                        Console.WriteLine("Informe um codigo");
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        // chamar o metodo
                        Console.WriteLine(this.autor.ConsultarPorCodigo(codigo));
                        break;
                    case 4:
                        Console.WriteLine("Excluir Autor");
                        break;
                    default:
                        Console.WriteLine("Codigo informado invalido!");
                        break;
                }
            }while (this.opcao != 0);
        }

    } // Fim do ControlAutor
}// Fim do projeto
