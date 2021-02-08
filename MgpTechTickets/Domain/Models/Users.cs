using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Models
{
    public class Users : BaseModel
    {
        public Users()
        {            
        }

        public Users(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;           
          
        }
        public Users(int id , string nome, string email, string senha, string token)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Token = token;

        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public Roles Role { get; set; }
        public IEnumerable<Chamado> Chamados { get; set; }
        public IEnumerable<Pendencia> Pendencias { get; set; }

    }
}
