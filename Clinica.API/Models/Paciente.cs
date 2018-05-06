using System;

namespace Clinica.API.Models
{
     public class Paciente : Pessoa
    {
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataObito { get; set; }
        public DateTime? DataUltimaConsulta { get; set; }

        public override bool EstaAtivo()
        {            
            return ! DataObito.HasValue && DataUltimaConsulta.HasValue;
        }

    }
}