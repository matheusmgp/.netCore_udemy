using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class SubCategoriaDtoRequest : BaseDtoModel
    {
        public string Nome { get; set; }
        public string Status_ { get; set; }
        public int CategoriaId { get; set; }
        public int AmbienteId { get; set; }
    }
}
