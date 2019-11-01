using Senai.Cleveland.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Cleveland.WebApi.Repositories
{
    public class EspecialidadeRepository
    {
        public List<Especialidade> Listar()
        {
            using (CleveLandContext ctx = new CleveLandContext())
            {
                return ctx.Especialidade.ToList();
            }
        }

        public void Cadastrar(Especialidade especialidade)
        {
            using (CleveLandContext ctx = new CleveLandContext())
            {
                ctx.Especialidade.Add(especialidade);
                ctx.SaveChanges();
            }
        }
    }
}
