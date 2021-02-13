using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("ChamadoLogs")]
    public class ChamadoLog : BaseModel
    {
        public ChamadoLog()
        {

        }

        public Users User { get; set; }
        public Chamado ChamadoFilho { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public Categoria Categoria { get; set; }
        public string Status_ { get; set; }
        public DateTime DataAlterado { get; set; }
        public string Tipo { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
