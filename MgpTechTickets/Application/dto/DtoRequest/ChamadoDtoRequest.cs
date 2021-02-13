using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class ChamadoDtoRequest : BaseDtoModel
    {
        public ChamadoDtoRequest(int userId, int filialId, int setorId, string status_, string protocolo, DateTime dataAbertura, int ambienteId)
        {
            UserId = userId;
            FilialId = filialId;
            SetorId = setorId;
            Status_ = status_;
            Protocolo = protocolo;
            DataAbertura = dataAbertura;
            AmbienteId = ambienteId;
        }

        public int UserId { get; set; }
        public int FilialId { get; set; }
        public int SetorId { get; set; }
        public string Status_ { get; set; }
        public string Protocolo { get; set; }
        public int UserIdFinish { get; set; }
        public int UserIdRedirect { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public int AmbienteId { get; set; }
    }
}
