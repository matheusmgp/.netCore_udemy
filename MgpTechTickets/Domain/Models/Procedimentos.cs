﻿using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Procedimentos : BaseModel
    {
        public Procedimentos()
        {

        }
        public Ambiente AmbienteId { get; set; }
        public string DescricaoValue { get; set; }
        public string Descricao { get; set; }
        public string Status_ { get; set; }
    }
}
