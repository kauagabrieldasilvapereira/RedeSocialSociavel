using Projeto1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocialSociavel
{
    internal class EnderecoDAO
    {
        public List<UserEndereco> SelectEndereco()
        {

            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM endereco";

            List<UserEndereco> users = new List<UserEndereco>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    UserEndereco objeto = new UserEndereco(

                    (int)dr["id"],
                    (string)dr["rua"],
                    (string)dr["numero"],
                    (string)dr["bairro"],
                    (string)dr["cep"],
                    (string)dr["cidade"],
                    (string)dr["estado"]
                    );

                    users.Add(objeto);
                }
                dr.Close();
                return users;//retornar a lista
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }
        public void UpdateEndereco(UserEndereco user)
        {
            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"UPDATE endereco SET 
             rua = @rua,
             numero = @numero,
             bairro = @bairro,
             cep = @cep,
             cidade = @cidade,
             estado = @estado
             WHERE id = @id"
            ;

            sqlCom.Parameters.AddWithValue("@rua", user.Rua);
            sqlCom.Parameters.AddWithValue("@numero", user.Numero);
            sqlCom.Parameters.AddWithValue("@bairro", user.Bairro);
            sqlCom.Parameters.AddWithValue("@cep", user.CEP);
            sqlCom.Parameters.AddWithValue("@cidade", user.Cidade);
            sqlCom.Parameters.AddWithValue("@estado", user.Estado);
            sqlCom.Parameters.AddWithValue("@id", user.Id);


            sqlCom.ExecuteNonQuery();
        }

        public void InsertEndereco(UserEndereco user)
        //aqui ele faz a conversão da senha normal para a senha criptografada atraves do metodo SHA256
        {
            {
                Conection conection = new Conection();
                SqlCommand sqlComand = new SqlCommand();

                sqlComand.Connection = conection.ReturnConnection();
                sqlComand.CommandText = @"INSERT INTO endereco VALUES (@rua, @numero, @bairro, @cep, @cidade, @estado)";

                sqlComand.Parameters.AddWithValue("@rua", user.Rua);
                sqlComand.Parameters.AddWithValue("@numero", user.Numero);
                sqlComand.Parameters.AddWithValue("@bairro", user.Bairro);
                sqlComand.Parameters.AddWithValue("@cep", user.CEP);
                sqlComand.Parameters.AddWithValue("@cidade", user.Cidade);
                sqlComand.Parameters.AddWithValue("@estado", user.Estado);

                sqlComand.ExecuteNonQuery();
            }
        }
        public void DeleteEndereco(int id)
        //aqui temos a aba para conseguirmos deletar algum usuario 
        {

            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM endereco WHERE Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

        }

    }
}