using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Cliente
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
