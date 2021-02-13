
using MgpTechTickets.Domain.repositories;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class AgendaService : IAgendaService
    {

        private readonly AgendasRepository _agendasRepository;

        public AgendaService(AgendasRepository agendasRepository)
        {
            _agendasRepository = agendasRepository;
        }

       
    }
}
