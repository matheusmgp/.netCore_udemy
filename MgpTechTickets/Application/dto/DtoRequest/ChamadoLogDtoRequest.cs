using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class ChamadoLogDtoRequest : BaseDtoModel
    {
        public int UserId { get; set; }
        public int ChamadoFilhoId { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public int CategoriaId { get; set; }
        public string Status_ { get; set; }
        public DateTime DataAlterado { get; set; }
        public string Tipo { get; set; }
        public int AmbienteId { get; set; }
    }
}
