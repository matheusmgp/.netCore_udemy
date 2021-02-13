using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Setores")]
    public class Setores : BaseModel
    {
        public Setores()
        {

        }
        public string Nome { get; set; }
        public string Status_ { get; set; }
        public string Tempo { get; set; }
        public string TempoRapido { get; set; }
        public string TempoMedio { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
