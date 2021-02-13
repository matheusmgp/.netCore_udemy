using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoReponse
{
    public class ProcedimentosDtoResponse : BaseDtoModel
    {
        public string DescricaoValue { get; set; }
        public string Descricao { get; set; }
        public string Status_ { get; set; }
    }
}
