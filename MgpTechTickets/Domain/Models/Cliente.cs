using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Clientes")]
    public class Cliente : BaseModel
    {
        public Cliente()
        {

        }

        public Cliente(string cliNome)
        {
           
            CliNome = cliNome;
        }

      
        public string CliNome { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
