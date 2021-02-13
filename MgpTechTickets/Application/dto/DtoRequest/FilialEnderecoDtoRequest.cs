using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoRequest
{
    public class FilialEnderecoDtoRequest : BaseDtoModel
    {
        public FilialEnderecoDtoRequest(int filialId, string logradouro, string cidade, string bairro, string cep, string numero)
        {
            FilialId = filialId;
            Logradouro = logradouro;
            Cidade = cidade;
            Bairro = bairro;
            Cep = cep;
            Numero = numero;
        }

        public int FilialId { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
