using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace AppEducaçãoDoFuturo
{
    class ClassFrequenciaAluno
    {
        public string Aluno_codAluno { get; set; }
        public string presenca { get; set; }

        //Criando o objeto da classe de conexão como banco de dados
        ClassAcessoBD bd = new ClassAcessoBD();

        //Método para inserir Frequência Aluno com o parametro do Código do Usuário que irá realizar o cadastro
        public bool InserirFrequenciaAluno(string codUsuarioLogado)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO FrequenciaAluno VALUES ('{0}','{1}')",
                    Aluno_codAluno, presenca));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados da frEquencia. ");
            }

        }

        //Método para editar Frequência Aluno com o parametro do Código do Frequência Aluno que irá ser editado
        public bool Editar(string codFrenquenciaAlunoEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE FrequenciaFunc SET presenca = '{0}' WHERE Aluno_codAluno = '{1}'", presenca, codFrenquenciaAlunoEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados desta frequência.");
            }
        }

        //Método para excluir Frequência Funcionário com o parametro do Código do Frequência Funcionário que irá ser excluido
        public bool Excluir(string codFrenquenciaAlunoExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM FrequenciaAluno WHERE Aluno_codAluno LIKE '{0}'", codFrenquenciaAlunoExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados da frequência. ");
            }
        }

        //Método para retornar os dados da frequencia do aluno 
        public DataTable RetFrequenciaAluno()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM FrequenciaAluno"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

        //Método para retornar um frequencia do aluno por busca
        public DataTable RetFrequenciaAlunoBusca(string cod)
        {
            //Conectando com o banco 
            bd.Conectar();
            //Objeto que recebe o SELECT para buscar por código da frequencia
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM FrequenciaAluno WHERE Aluno_codAluno LIKE '%{0}%'", cod));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }
    }
}