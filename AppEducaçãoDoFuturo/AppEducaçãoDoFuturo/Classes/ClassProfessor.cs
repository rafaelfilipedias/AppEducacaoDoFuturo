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
    class ClassProfessor
    {
        //Declarando as propriedades
        public string CodProfessor { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataNasc { get; set; }
        public string DataCadastro { get; set; }
        public string Usuario { get; set; }
        public string CoordenadorCurso_codCoordenador { get; set; }
        public string Senha { get; set; }

        //Criando o objeto da classe de conexão como banco de dados
        ClassAcessoBD bd = new ClassAcessoBD();

        //Método para inserir Professor com o parametro do Código do Usuário que irá realizar o cadastro
        public bool InserirProfessor(string codUsuarioLogado)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Professor VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    CodProfessor, Nome, Cpf, Telefone, Email, DataNasc, DataCadastro, Usuario, Senha,codUsuarioLogado));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados do professor. ");
            }

        }

        //Método para editar Professor com o parametro do Código do Professor que irá ser editado
        public bool Editar(string codProfessorEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Professor SET nome = '{0}', telefone = '{1}', email = '{2}', usuario = '{3}' WHERE codProfessor = '{4}'", Nome,Telefone, Email,Usuario, codProfessorEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados deste professor.");
            }
        }

        //Método para excluir Professor com o parametro do Código do Professor que irá ser excluido
        public bool Excluir(string codProfessorExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM Professor WHERE codProfessor LIKE '{0}'", codProfessorExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados do professor. ");
            }
        }

        //Método para retornar os dados do professor 
        public DataTable RetProfessor()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

        //Propriedade para verificar o CPF
        public string CpfDigitado { get; set; }
        //Método para validar se o cpf digitado já está no banco
        public bool ValidarCpf()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor WHERE cpf LIKE '{0}'", CpfDigitado));
            // Desconectando o banco 
            bd.Desconectar();
            //Se o objeto dt não retornar nada ele não existe
            if (dt.Rows.Count == 0)
            {
                //Se não existe retorna true
                return false;
            } //Se retornar mais de uma linha ele já existe no banco
            else
            {
                //Se existe 
                return true;
            }
        }

        //Propriedade para validar o email 
        public string EmailDigitado { get; set; }
        //Método para validar se o email digitado já está no banco
        public bool ValidarEmail()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor WHERE email LIKE '{0}'", EmailDigitado));
            // Desconectando o banco 
            bd.Desconectar();
            //Se o objeto dt não retornar nada ele não existe
            if (dt.Rows.Count == 0)
            {
                //Se não existe retorna true
                return false;
            }
            else //Se retornar mais de uma linha ele já existe no banco
            {
                //Declarando a váriavel local
                bool teste = false;
                //Um for para percorrer o email digitado 
                for (int i = 0; i < EmailDigitado.Length; i++)
                {
                    //um if para conferir se o email possui @
                    if (EmailDigitado[i] == char.Parse("@"))
                    {
                        //Se tiver o teste recebe tur
                        teste = true;
                    }
                }
                //If para conferir se o email tem mais de 5 caracteres
                if ((EmailDigitado.Length > 5) && (teste == true))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Método para retornar um professor por busca
        public DataTable RetProfessorBusca(string cod)
        {
            //Conectando com o banco 
            bd.Conectar();
            //Objeto que recebe o SELECT para buscar por código ou cpf do professor
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor WHERE codProfessor LIKE '%{0}%' OR cpf LIKE '%{0}%'", cod));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }

        //Realizar o login
        public DataTable RealizarLogin()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor WHERE usuario LIKE '{0}' AND senha LIKE '{1}'", Usuario, Senha));
            bd.Desconectar();
            return dt;
        }
    }
}