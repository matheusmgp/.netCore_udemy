using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Procedimentos")]
    public class Procedimentos : BaseModel
    {
        public Procedimentos()
        {

        }
        public Ambiente Ambiente { get; set; }
        public string DescricaoValue { get; set; }
        public string Descricao { get; set; }
        public string Status_ { get; set; }
    }
}
