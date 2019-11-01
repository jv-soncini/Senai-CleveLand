using System;
using System.Collections.Generic;

namespace Senai.Cleveland.WebApi.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdEspecialidade { get; set; }
        public string Especialidade1 { get; set; }

        public ICollection<Medicos> Medicos { get; set; }
    }
}
