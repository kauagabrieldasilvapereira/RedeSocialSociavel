using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialSociavel
{
    internal class User
    {
        private string _nome;
        private string _email;
        private string _senha;
        public User(string nome,
                    string email,
                    string senha)
        {

            Nome = _nome;
            Email = _email;
            Senha = _senha;
        }

        public string Nome
        {
            set { Nome = value; }
            get { return _nome; }

        }

        public string Email
        {
            set { Email = value; }
            get { return _email; }

        }

        public string Senha
        {
            set { Senha = value; }
            get { return _senha; }

        }
    }
}

