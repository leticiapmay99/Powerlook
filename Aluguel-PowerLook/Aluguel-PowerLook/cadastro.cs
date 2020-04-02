using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aluguel_PowerLook
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand comm = new SqlCommand();

        public String mensagem="";

        public Cadastro(String nome, String email , String cpf)
        {
            comm.CommandText = "insert into Teste(Nome, Email, CPF) Values (@Nome, @Email, @CPF)";
            comm.Parameters.AddWithValue("@Nome", nome);
            comm.Parameters.AddWithValue("@Email", email);
            comm.Parameters.AddWithValue("@CPF", cpf);

            try
            {
                comm.Connection = conexao.conectar();
                comm.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao cadastrar!";
            }
        }
    }
}
