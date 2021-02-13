using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Ambientes")]
    public class Ambiente : BaseModel
    {
        public Ambiente()
        {

        }

        public Ambiente(string nomeFantasia, string razaoSocial, string cnpj, string cpf, string email)
        {
           
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Cpf = cpf;
            Email = email;
        }

       
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
