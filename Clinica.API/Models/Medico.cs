using System;

namespace Clinica.API.Models
{
    public class Medico : Pessoa
    {
        public Especialidade Especialidade { get; set; }
        public string Crm { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }

        public override bool EstaAtivo()
        {            
            return ! DataDemissao.HasValue;
        }
        public bool EstaValido()
        {
            return ! string.IsNullOrEmpty(Crm);
        }

}