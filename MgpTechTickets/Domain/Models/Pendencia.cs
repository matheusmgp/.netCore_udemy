using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Pendencias")]
    public class Pendencia : BaseModel
    {
        public Pendencia()
        {

        }
        public Users User { get; set; }
        public Users UserFinish { get; set; }
        public Chamado Chamado { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public Categoria Categoria { get; set; }
        public SubCategorias SubCategoria { get; set; }
        public CanaisComunicacao Canal { get; set; }
        public string Imagem { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public Ambiente Ambiente { get; set; }
        public string PendenciaImagem { get; set; }
    }
}
