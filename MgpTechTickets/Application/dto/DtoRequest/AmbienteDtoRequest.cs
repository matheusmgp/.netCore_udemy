using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class AmbienteDtoRequest :BaseDtoModel
    {
        public AmbienteDtoRequest(string nomeFantasia, string razaoSocial, string cnpj, string cpf, string email)
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
