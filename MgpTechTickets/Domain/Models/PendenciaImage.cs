using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class PendenciaImage : BaseModel
    {
        public PendenciaImage()
        {

        }
        public Pendencia ChamadoFilhoId { get; set; }
        public string PathName { get; set; }
        public Ambiente AmbienteId { get; set; }
    }
}
