using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocialSociavel 
{

    internal class User
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _senha;
        public User(string nome,
                    string email,
                    string senha)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public User(int id, string nome,
                   string email,
                   string senha)
        {
            Id = id;

            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public int Id
        {
            set
            {
                _id = value;
            }
            get { return _id; }

        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                throw new Exception("O campo nome está vazio");
                    
                _nome = value;
            }
            get { return _nome; }

        }

        private bool linkLabel1(bool v)
        {
            throw new NotImplementedException();
        }

        public string Email
        {
            set
            {

                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo email está vazio");

                _email = value;
            }
            get { return _email; }

        }

        public string Senha
        {
            set
            {

                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo senha está vazio");

                _senha = value;
            }
            get { return _senha; }

        }
    }
}

