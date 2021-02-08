using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Filial
    {
        public Filial()
        {

        }

        public Filial(int id, string filCnpj, string filRazsoc, string filStatus, string filNomefant, int ambienteId)
        {
            Id = id;
            FilCnpj = filCnpj;
            FilRazsoc = filRazsoc;
            FilStatus = filStatus;
            FilNomefant = filNomefant;
            AmbienteId = ambienteId;
        }

        public int Id { get; set; }
        public string FilCnpj { get; set; }
        public string FilRazsoc { get; set; }
        public string FilStatus { get; set; }
        public string FilNomefant { get; set; }
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }

    }
}
