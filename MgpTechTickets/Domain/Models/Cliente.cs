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

        public Cliente(int id, string cliNome, int ambienteId)
        {
            Id = id;
            CliNome = cliNome;
            AmbienteId = ambienteId;
        }

        public int Id { get; set; }
        public string CliNome { get; set; }
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
