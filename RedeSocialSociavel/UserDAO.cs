using Projeto1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocialSociavel
{
    internal class UserDAO
    {

        public List<User> SelectUser()
        {

            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM login";

            List<User> users = new List<User>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    User objeto = new User(

                    (int)dr["id"],
                    (string)dr["nnCliente"],
                    (string)dr["emailCliente"],
                    (string)dr["senhaCliente"]
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

        public void InsertUser(User user)

        {
            Conection conection = new Conection();
            SqlCommand sqlComand = new SqlCommand();

            sqlComand.Connection = conection.ReturnConnection();
            sqlComand.CommandText = @"INSERT INTO login VALUES (@nome, @email, @senha)";

            sqlComand.Parameters.AddWithValue("@nome", user.Nome);
            sqlComand.Parameters.AddWithValue("@email", user.Email);
            sqlComand.Parameters.AddWithValue("@senha", user.Senha);

            sqlComand.ExecuteNonQuery();
        }

        public void DelelteUser(int id)
        {

            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM login WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
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

