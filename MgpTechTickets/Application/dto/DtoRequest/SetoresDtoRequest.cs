using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class SetoresDtoRequest : BaseDtoModel
    {
        public SetoresDtoRequest(string nome, string status_, string tempo, string tempoRapido, string tempoMedio, int ambienteId)
        {
            Nome = nome;
            Status_ = status_;
            Tempo = tempo;
            TempoRapido = tempoRapido;
            TempoMedio = tempoMedio;
            AmbienteId = ambienteId;
        }

        public string Nome { get; set; }
        public string Status_ { get; set; }
        public string Tempo { get; set; }
        public string TempoRapido { get; set; }
        public string TempoMedio { get; set; }
        public int AmbienteId { get; set; }
    }
}
