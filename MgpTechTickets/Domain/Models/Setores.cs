﻿using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
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
        public Ambiente AmbienteId { get; set; }
    }
}
