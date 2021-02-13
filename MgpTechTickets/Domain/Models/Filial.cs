﻿using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Filial : BaseModel
    {
        public Filial()
        {

        }

        public Filial(string filCnpj, string filRazsoc, string filStatus, string filNomefant)
        {
           
            FilCnpj = filCnpj;
            FilRazsoc = filRazsoc;
            FilStatus = filStatus;
            FilNomefant = filNomefant;
        }

   
        public string FilCnpj { get; set; }
        public string FilRazsoc { get; set; }
        public string FilStatus { get; set; }
        public string FilNomefant { get; set; }
     
        public Ambiente AmbienteId { get; set; }

    }
}
