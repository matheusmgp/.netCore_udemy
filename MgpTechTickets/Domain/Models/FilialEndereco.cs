using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class FilialEndereco
    {
        public FilialEndereco()
        {

        }

        public FilialEndereco(int filialId, string logradouro, string cidade, string bairro, string cep, string numero, string complemento)
        {
            FilialId = filialId;
            Logradouro = logradouro;
            Cidade = cidade;
            Bairro = bairro;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
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
