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
    class ClassFrequenciaProf
    {
        public string Professor_codProfessor { get; set; }
        public string Presenca { get; set; }
        public string AtestadoMedico { get; set; }


        //Criando o objeto da classe de conexão como banco de dados
        ClassAcessoBD bd = new ClassAcessoBD();

        //Método para inserir Frequência Funcionário com o parametro do Código do Usuário que irá realizar o cadastro
        public bool InserirFrequenciaProf()
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO FrequenciaProf VALUES ('{0}','{1}','{2}')",
                    Professor_codProfessor, AtestadoMedico, Presenca));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados da frequencia. ");
            }

        }



        //Método para retornar os dados da frequencia do funcionario 
        public DataTable RetFrequenciaProf()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM FrequenciaProf"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

       
    }
}
