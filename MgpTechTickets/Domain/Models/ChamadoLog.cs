using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class ChamadoLog : BaseModel
    {
        public ChamadoLog()
        {

        }

        public Users UserId { get; set; }
        public Chamado ChamadoFilhoId { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public Categoria CategoriaId { get; set; }
        public string Status_ { get; set; }
        public DateTime DataAlterado { get; set; }
        public string Tipo { get; set; }
        public Ambiente AmbienteId { get; set; }
    }
}
