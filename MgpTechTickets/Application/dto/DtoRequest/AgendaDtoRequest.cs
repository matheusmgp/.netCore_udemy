using MgpTechTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class AgendaDtoRequest : BaseDtoModel
    {
        
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public int AmbienteId { get; set; }
    }
}
