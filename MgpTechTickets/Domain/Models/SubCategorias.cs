using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("SubCategorias")]
    public class SubCategorias : BaseModel
    {
        public SubCategorias()
        {

        }
        public string Nome { get; set; }
        public string Status_ { get; set; }
        public Categoria Categoria { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
