using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDAOXML
{
    public class Cliente
    {
        private string nome;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
    }
}
