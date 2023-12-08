using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViaCP
{
    public class Endereco
    {
        public int id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ddd { get; set; }



        public DataTable ListarTudo()
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD banco = new ConexaoBD();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM enderecos";
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            banco.Desconectar();
            return tabela;
        }

        public DataTable SalvarCEP()
        {
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD banco = new ConexaoBD();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            cmd.CommandText = "INSERT INTO enderecos (cep,logradouro,bairro,ddd,localidade, complemento, uf)" +
               "VALUES (@cep, @logradouro, @bairro, @ddd, @localidade, @complemento, @uf)";
            // Substituir parâmetros da query:
            
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@ddd", Ddd);
            cmd.Parameters.AddWithValue("@localidade", Localidade);
            cmd.Parameters.AddWithValue("@complemento", Complemento);
            cmd.Parameters.AddWithValue("@uf", Uf);
            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();
            return tabela;

        }




        public DataTable ApagarTudo()
        {
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD banco = new ConexaoBD();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            cmd.CommandText = "DELETE FROM enderecos ";

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();
            return tabela;
        }
        public DataTable DeletarSelecionado()
        {
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD banco = new ConexaoBD();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            cmd.CommandText = "DELETE FROM enderecos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();
            return tabela;
        }
    }
}

        
  
