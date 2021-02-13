using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoReponse
{
    public class FilialDtoResponse : BaseDtoModel
    {
        public string FilCnpj { get; set; }
        public string FilRazsoc { get; set; }
        public string FilStatus { get; set; }
        public string FilNomefant { get; set; }
    }
}
