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
    class ClassTurma
    {
        public string CodTurma { get; set; }
        public string Professor_codProfessor { get; set; }
        public string Nome { get; set; }
        public string NumAlunos { get; set; }
        public string DistribuicaoDePontos { get; set; }

        //Criando o objeto da classe de conexão como banco de dados
        ClassAcessoBD bd = new ClassAcessoBD();

        //Método para inserir Turma com o parametro do Código do Usuário que irá realizar o cadastro
        public bool InserirTurma()
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Turma VALUES ('{0}','{1}','{2}','{3}',{4})",
                    CodTurma, Professor_codProfessor, Nome, NumAlunos, DistribuicaoDePontos));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados da turma. ");
            }

        }

        //Método para editar Turma com o parametro do Código do Turma que irá ser editado
        public bool Editar(string codTurmaEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Turma SET nome = '{0}', numAlunos = {1}, distribuicaoDePontos = '{2}', Profesor_codProfessor = '{3}' WHERE codTurma = '{4}'", Nome, NumAlunos, DistribuicaoDePontos, Professor_codProfessor, codTurmaEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados deste curso.");
            }
        }

        //Método para excluir Turma com o parametro do Código do Turma que irá ser excluido
        public bool Excluir(string codTurmaExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM Turma WHERE codTurma LIKE '{0}'", codTurmaExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados do turma. ");
            }
        }

        //Método para retornar os dados do curso 
        public DataTable RetTurma()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Turma"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

        //Método para retornar um curso por busca
        public DataTable RetTurmaBusca(string cod)
        {
            //Conectando com o banco 
            bd.Conectar();
            //Objeto que recebe o SELECT para buscar por código da turma
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Turma WHERE codTurma LIKE '%{0}%'", cod));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }
    }
}
