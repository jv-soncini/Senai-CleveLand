using System;
using System.Collections.Generic;

namespace Senai.Cleveland.WebApi.Domains
{
    public partial class Medicos
    {
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Crm { get; set; }
        public bool? Estado { get; set; }
        public int? Especialidade { get; set; }

        public Especialidade EspecialidadeNavigation { get; set; }
    }
}
