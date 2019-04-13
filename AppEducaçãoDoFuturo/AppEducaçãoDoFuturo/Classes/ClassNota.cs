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
    class ClassNota
    {
        public string Aluno_codAluno { get; set; }
        public string Professor_codProfessor { get; set; }
        public float Prova1 { get; set; }
        public float Prova2 { get; set; }
        public float Trabalho { get; set; }

        //Criando o objeto da classe de conexão como banco de dados
        ClassAcessoBD bd = new ClassAcessoBD();

        //Método para inserir Nota com o parametro do Código do Usuário que irá realizar o cadastro
        public bool InserirNota(string codUsuarioLogado)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Nota VALUES ('{0}','{1}',{2},{3},{4})",
                    Aluno_codAluno, codUsuarioLogado, Prova1, Prova2, Trabalho));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados da nota. ");
            }

        }

        //Método para editar Nota com o parametro do Código do Nota que irá ser editado
        public bool Editar(string codNotaEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Nota SET prova1 = '{0}', prova2 = '{1}', trabalho = '{2}' WHERE Aluno_codAluno = '{3}'", Prova1, Prova2, Trabalho, codNotaEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados desta nota.");
            }
        }

        //Método para excluir Nota com o parametro do Código do Nota que irá ser excluido
        public bool Excluir(string codNotaExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM Nota WHERE Aluno_codAluno LIKE '{0}'", codNotaExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados da nota. ");
            }
        }

        //Método para retornar os dados do curso 
        public DataTable RetNota()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Nota"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

        //Método para retornar um curso por busca
        public DataTable RetNotaBusca(string cod)
        {
            //Conectando com o banco 
            bd.Conectar();
            //Objeto que recebe o SELECT para buscar por código da nota
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Nota WHERE Aluno_codAluno LIKE '%{0}%'", cod));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }
    }
}