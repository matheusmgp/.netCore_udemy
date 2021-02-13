using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.DtoReponse
{
    public class PendenciaDtoResponse : BaseDtoModel
    {
        public int UserId { get; set; }
        public int UserIdFinish { get; set; }
        public int ChamadoId { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public int CategoriaId { get; set; }
        public int SubCategoriaId { get; set; }
        public int CanalId { get; set; }
        public string Imagem { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }       
        public string PendenciaImagem { get; set; }
    }
}
