using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class SubCategorias : BaseModel
    {
        public SubCategorias()
        {

        }
        public string Nome { get; set; }
        public string Status_ { get; set; }
        public Categoria CategoriaId { get; set; }
        public Ambiente AmbienteId { get; set; }
    }
}
