using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Agenda : BaseModel
    {
        public Agenda()
        {

        }

        public Agenda(string nome, string telefone, string email, string observacao)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Observacao = observacao;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public Ambiente AmbienteId { get; set; }
    }
}
