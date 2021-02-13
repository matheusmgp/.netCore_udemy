using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Pendencia : BaseModel
    {
        public Pendencia()
        {

        }
        public Users UserId { get; set; }
        public Users UserIdFinish { get; set; }
        public Chamado ChamadoId { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public Categoria CategoriaId { get; set; }
        public SubCategorias SubCategoriaId { get; set; }
        public CanaisComunicacao CanalId { get; set; }
        public string Imagem { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public Ambiente AmbienteId { get; set; }
        public string PendenciaImagem { get; set; }
    }
}
