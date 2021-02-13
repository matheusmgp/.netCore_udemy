using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoReponse
{
    public class CategoriaDtoResponse : BaseDtoModel
    {
        public string Nome { get; set; }
        public string Status_ { get; set; }
    }
}
