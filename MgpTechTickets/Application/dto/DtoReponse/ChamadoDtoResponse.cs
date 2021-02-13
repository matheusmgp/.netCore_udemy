using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoReponse
{
    public class ChamadoDtoResponse : BaseDtoModel
    {
        public int UserId { get; set; }
        public int FilialId { get; set; }
        public int SetorId { get; set; }
        public string Status_ { get; set; }
        public string Protocolo { get; set; }
        public int UserIdFinish { get; set; }
        public int UserIdRedirect { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
      
    }
}
