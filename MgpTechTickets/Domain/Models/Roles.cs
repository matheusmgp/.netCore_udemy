using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Roles : BaseModel
    {
        public Roles()
        {

        }

        public string Nome { get; set; }
        public Ambiente AmbienteId { get; set; }
    }
}
