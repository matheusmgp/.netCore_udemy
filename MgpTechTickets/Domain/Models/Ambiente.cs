using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Ambiente
    {
        public Ambiente()
        {

        }

        public Ambiente(int id, string nomeFantasia, string razaoSocial, string cnpj, string cpf, string email)
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Cpf = cpf;
            Email = email;
        }

        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
