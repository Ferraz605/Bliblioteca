using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

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
                        Console.WriteLine("Atualizar Autor");

                        Console.WriteLine("Informe o codigo do autor que deseja atualizar");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        // criar um menu para atualização
                        Console.WriteLine("Escolha qual campo deseja atualizar:\n\n" +
                            "\n1. Nome" +
                            "\n2. Genero" +
                            "\n3. Endereço");

                        int opcaocampo = Convert.ToInt32(Console.ReadLine());
                        string campo = "";

                        // escolha
                        switch (opcaocampo)
                        {
                            case 1:
                                campo = "nome";
                            break;
                            case 2:
                                campo = "genero";
                            break;
                            case 3:
                                campo = "endereco";
                            break;
                            default:
                                Console.WriteLine("Não é possivel atualizar! Escolha um campo valido");
                            break;
                        } // fim do escolha caso

                        // pedir o novo dado
                        Console.WriteLine($"Informe o {campo}");
                        string novodado = Console.ReadLine();
                        Console.WriteLine(this.autor.Atualizar(codigo, campo, novodado));
                        break;
                    case 5:
                        Console.WriteLine("Excluir autor");
                        Console.WriteLine("Informe o autor que deseja excluir: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.autor.Deletar(codigo));
                        break;
                    default:
                        Console.WriteLine("Codigo informado invalido!");
                        break;
                }
            }while (this.opcao != 0);
        }

    } // Fim do ControlAutor
}// Fim do projeto
