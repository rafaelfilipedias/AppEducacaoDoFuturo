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
    class ClassCurso
    {
        public string CodCurso { get; set; }
        public string Nome { get; set; }
        public string PlanoDeAula { get; set; }
        public string ConteudoCurso { get; set; }
        public string PlanoCurso { get; set; }
        public string Diretor_codDiretor { get; set; }
        public string CoordenadorCurso_codCoordenador { get; set; }

        //Criando o objeto da classe de conexão como banco de dados
        ClassAcessoBD bd = new ClassAcessoBD();

        //Método para inserir Curso com o parametro do Código do Usuário que irá realizar o cadastro
        public bool InserirCurso(string codUsuarioLogado)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Curso VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    CodCurso, Nome, PlanoDeAula, ConteudoCurso, PlanoCurso, codUsuarioLogado, CoordenadorCurso_codCoordenador ));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados do curso. ");
            }

        }

        //Método para editar Curso com o parametro do Código do Curso que irá ser editado
        public bool Editar(string codCursoEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Curso SET nome = '{0}', planoDeAula = '{1}', conteudoCurso = '{2}', planoCurso = '{3}' WHERE codCurso = '{4}'", Nome, PlanoDeAula, ConteudoCurso, PlanoCurso, codCursoEditar));
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

        //Método para excluir Curso com o parametro do Código do Curso que irá ser excluido
        public bool Excluir(string codCursoExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM Curso WHERE codCurso LIKE '{0}'", codCursoExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados do curso. ");
            }
        }

        //Método para retornar os dados do curso 
        public DataTable RetCurso()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Curso"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

        //Método para retornar um curso por busca
        public DataTable RetCursoBusca(string cod)
        {
            //Conectando com o banco 
            bd.Conectar();
            //Objeto que recebe o SELECT para buscar por código do curso
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Curso WHERE codCurso LIKE '%{0}%'", cod));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }
    }
}
