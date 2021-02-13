using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Chamados")]
    public class Chamado : BaseModel
    {
        public Users User { get; set; }
        public Filial Filial { get; set; }
        public Setores Setor { get; set; }
        public string Status_ { get; set; }
        public string Protocolo { get; set; }
        public Users UserFinish { get; set; }
        public Users UserRedirect { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public Ambiente Ambiente { get; set; }
        public IEnumerable<Pendencia> Pendencias { get; set; }
    }
}
