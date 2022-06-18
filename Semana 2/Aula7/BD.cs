using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    public class BD
    {
        private string login;
        private string senha;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public BD(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }
    }
}
