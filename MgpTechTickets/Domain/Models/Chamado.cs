using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Chamado : BaseModel
    {
        public Users UserId { get; set; }
        public Filial FilialId { get; set; }
        public Setores SetorId { get; set; }
        public string Status_ { get; set; }
        public string Protocolo { get; set; }
        public Users UserIdFinish { get; set; }
        public Users UserIdRedirect { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public Ambiente AmbienteId { get; set; }
        public IEnumerable<Pendencia> Pendencias { get; set; }
    }
}
