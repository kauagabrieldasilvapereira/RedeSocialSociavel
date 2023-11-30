using Projeto1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
        public void UpdateUser(User user)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Senha));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                string SenhaCriptografada = sb.ToString();
                Conection conn = new Conection();
                SqlCommand sqlCom = new SqlCommand();

                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = @"UPDATE login SET 
             nnCliente = @nome,
             emailCliente = @email,
             senhaCliente = @senha
             WHERE id = @id"
                ;

                sqlCom.Parameters.AddWithValue("@nome", user.Nome);
                sqlCom.Parameters.AddWithValue("@email", user.Email);
                sqlCom.Parameters.AddWithValue("@senha", SenhaCriptografada);
                sqlCom.Parameters.AddWithValue("@id", user.Id);


                sqlCom.ExecuteNonQuery();
            }
        }

        public void InsertUser(User user)
            //aqui ele faz a conversão da senha normal para a senha criptografada atraves do metodo SHA256
        {

            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Senha));
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    string SenhaCriptografada = sb.ToString();

                    Conection conection = new Conection();
                    SqlCommand sqlComand = new SqlCommand();

                    sqlComand.Connection = conection.ReturnConnection();
                    sqlComand.CommandText = @"INSERT INTO login VALUES (@nome, @email, @senha)";

                    sqlComand.Parameters.AddWithValue("@nome", user.Nome);
                    sqlComand.Parameters.AddWithValue("@email", user.Email);
                    sqlComand.Parameters.AddWithValue("@senha", SenhaCriptografada);

                    sqlComand.ExecuteNonQuery();
                }
            }
        }

        public void DelelteUser(int id)
            //aqui temos a aba para conseguirmos deletar algum usuario 
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

        public bool LoginUser(string email, string senha)
        {

            {
                Conection connection = new Conection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "SELECT * FROM login WHERE + emailCliente = @email AND senhaCliente = @senha";

                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@senha", senha);
                try
                {
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.HasRows)
                    {

                        dr.Close();
                        return true;
                    }
                    dr.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }
                return false;
            }


        }
    }

}



