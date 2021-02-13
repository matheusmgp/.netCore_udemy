using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class ClienteDtoRequest :BaseDtoModel
    {
        public ClienteDtoRequest(string cliNome, int ambiente)
        {
            CliNome = cliNome;
            Ambiente = ambiente;
        }

        public string CliNome { get; set; }
        public int Ambiente { get; set; }
    }
}
