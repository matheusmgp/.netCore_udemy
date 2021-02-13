using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    [Table("Categorias")]
    public class Categoria : BaseModel
    {
        public Categoria()
        {

        }

        public Categoria(string nome, string status_)
        {
            Nome = nome;
            Status_ = status_;
        }

        public string Nome { get; set; }
        public string Status_ { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
