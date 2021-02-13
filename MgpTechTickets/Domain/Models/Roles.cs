using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Roles")]
    public class Roles : BaseModel
    {
        public Roles()
        {

        }

        public string Nome { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
