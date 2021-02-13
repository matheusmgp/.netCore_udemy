using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class CategoriaDtoRequest : BaseDtoModel
    {
        public CategoriaDtoRequest(string nome, string status_, int ambienteId)
        {
            Nome = nome;
            Status_ = status_;
            AmbienteId = ambienteId;
        }

        public string Nome { get; set; }
        public string Status_ { get; set; }
        public int AmbienteId { get; set; }
    }
}
