using System;
using Clinica.API.Models.Interfaces;

namespace Clinica.API.Models
{
    public abstract class Entidade : IEntidade
{
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }

        public virtual bool EstaAtivo()
        {

            return false;
        }
    }
   
}