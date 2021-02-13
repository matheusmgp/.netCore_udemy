using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class FilialDtoRequest : BaseDtoModel
    {
        public FilialDtoRequest(string filCnpj, string filRazsoc, string filStatus, string filNomefant, int ambienteId)
        {
            FilCnpj = filCnpj;
            FilRazsoc = filRazsoc;
            FilStatus = filStatus;
            FilNomefant = filNomefant;
            AmbienteId = ambienteId;
        }

        public string FilCnpj { get; set; }
        public string FilRazsoc { get; set; }
        public string FilStatus { get; set; }
        public string FilNomefant { get; set; }
        public int AmbienteId { get; set; }
       
    }
}
