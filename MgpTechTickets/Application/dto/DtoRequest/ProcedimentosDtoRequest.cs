using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class ProcedimentosDtoRequest : BaseDtoModel
    {
        public ProcedimentosDtoRequest(int ambienteId, string descricaoValue, string descricao, string status_)
        {
            AmbienteId = ambienteId;
            DescricaoValue = descricaoValue;
            Descricao = descricao;
            Status_ = status_;
        }

        public int AmbienteId { get; set; }
        public string DescricaoValue { get; set; }
        public string Descricao { get; set; }
        public string Status_ { get; set; }
    }
}
