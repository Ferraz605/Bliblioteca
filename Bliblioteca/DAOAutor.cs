using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // importando os comandos de conexão com o banco
using System.Windows.Forms; // Importando estrutura de telas

namespace Bliblioteca 
{
    class DAOAutor
    {
        public MySqlConnection conexao; // criando variavel que representa o banco
        public string dados;
        public string comando;
        public int[] codigo;
        public string[] nome;
        public string[] genero;
        public string[] endereco;
        public int i;
        public int contar;
        public string msg;

        public DAOAutor()
        {
            // Conexão com banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=registro;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                this.conexao.Open(); // Abrir a conexão
                MessageBox.Show("Conectado com Sucesso!");
            }catch(Exception erro ){
                MessageBox.Show($"Algo deu errado!\n\n {erro}");
                this.conexao.Close(); // Fechar a conexão com o BD
            }// Fim do try e catch
        } // FIM DO CONSTRUTOR

        // Inserir  o dado no banco
        public void Inserir(string nome, string genero, string endereco)
        {
            try
            {
                this.dados = $"('','{nome}','{genero}','{endereco}')";
                this.comando = $"Insert into autor(codigo,nome,genero,endereco) values{this.dados}";
                // inserir comando no banco[
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery(); // executo com comando
                MessageBox.Show($"Inserido Com sucesso!\n\n {resultado}");
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Algo de errado {erro}");
            }
        }// FIm do INSERIR

        // Preencher Vetor - - > Coletar os dados do banco e preencher o vetor

        public void PreencherVetor()
        {
            string query = "Select * from autor"; // Buscando todos os dados da tabela autor

            // instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.genero = new string[100];
            this.endereco = new string[100];

            // Preencher os vetores com valores padrães

            for (int i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.nome[i] = "";
                this.genero[i] = "";
                this.endereco[i] = "";
            }

            // Executar comando do SQL

            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            // Leitura dos dados no banco
            MySqlDataReader leitura = coletar.ExecuteReader(); // Percorre o banco e trás os dados

            // Zerar o contador
            i = 0;
            this.contar = 0;

            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.nome[i] = leitura["nome"] + "";
                this.genero[i] = leitura["genero"] + "";
                this.endereco[i] = leitura["endereco"] + "";
                i++;
                this.contar++; // informar quantos dados tem no banco
            } // fim do while 

            leitura.Close(); // encerrando processo de busca 

        } // Fim do metodo

        public string ConsultarTudo ()
        {
            PreencherVetor(); // Preencher todos os dados do vetor
            this.msg = "";
            for (int i = 0; i < this.contar; i++)
            {
                this.msg += $"\nCodigo: {this.codigo[i]}" +
                    $"\nNome: {this.nome[i]}" +
                    $"\nGenero: {this.genero[i]}" +
                    $"\nEndereço: {this.endereco[i]}\n\n";
            }
            return this.msg;
        } // fim do codigo consulta

        public string ConsultarPorCodigo(int codigo)
        {
            PreencherVetor(); // Preencher todos os dados do vetor
            this.msg = "";
            for (int i = 0; i < this.contar; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    this.msg += $"\nCodigo: {this.codigo[i]}" +
                        $"\nNome: {this.nome[i]}" +
                        $"\nGenero: {this.genero[i]}" +
                        $"\nEndereço: {this.endereco[i]}\n\n";
                    return this.msg;

                }

            }
            return "Codigo informado não existe";
        }


        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update autor set {campo} = '{novoDado}' where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery(); // comando de inserção no banco
                return $"Atualizado com sucesso\n\n {resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }

        }

        public string Deletar(int codigo)
        {
            try
            {
                string query = $"delete from autor where codigo = {codigo}";
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery(); // comando de inserção no banco
                return $"Deletado com sucesso\n\n {resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }
        }
        } // FIM DA CLASSE 
} // FIM DO PROJETO 
