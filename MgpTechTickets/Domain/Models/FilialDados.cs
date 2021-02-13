﻿using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class FilialDados : BaseModel
    {
        public FilialDados()
        {

        }

       
        public Filial FilialId { get; set; }
        public string NomeRepre { get; set; }
        public string NomeFinan { get; set; }
        public string CpfRepre { get; set; }
        public string EmailFinan { get; set; }
        public string IdentiRepre { get; set; }
        public string TeleFinan { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
