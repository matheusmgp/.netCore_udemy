using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class RolesDtoRequest : BaseDtoModel
    {
        public string Nome { get; set; }
        public int AmbienteId { get; set; }
    }
}
