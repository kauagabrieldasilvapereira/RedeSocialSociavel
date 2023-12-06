using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialSociavel
{
    internal class UserEndereco
    {
        private int _id;
        private string _rua;
        private string _numero;
        private string _bairro;
        private string _cep;
        private string _cidade;
        private string _estado;
        public UserEndereco(string rua,
                    string numero,
                    string bairro,
                    string cep,
                    string cidade,
                    string estado)
        {

            Rua = rua;
            Numero = numero;
            Bairro  = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }
        public UserEndereco(int id, string rua,
                    string numero,
                    string bairro,
                    string cep,
                    string cidade,
                    string estado)
        {
            Id = id;

            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }
        public int Id
        {
            set
            {
                _id = value;
            }
            get { return _id; }

        }

        public string Rua
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo nome está vazio");

                _rua = value;
            }
            get { return _rua; }

        } 
        public string Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo nome está vazio");

                _numero = value;
            }
            get
            {
                return _numero;
            }
        }

        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo nome está vazio");

                _bairro = value;
            }
            get
            {
                return _bairro;
            }
        }
        public string CEP
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo nome está vazio");

                _cep = value;
            }
            get
            {
                return _cep;
            }
        }

        public string Cidade
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo nome está vazio");

                _cidade = value;
            }
            get
            {
                return _cidade;
            }
        }
        private bool linkLabel1(bool v)
        {
            throw new NotImplementedException();
        }

        public string Estado
        {
            set
            {

                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo senha está vazio");

                _estado = value;
            }
            get { return _estado; }

        }
    }
}

