using Senai.Cleveland.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Cleveland.WebApi.Repositories
{
    public class MedicosRepository
    {
       public List<Medicos> Listar()
        {
            using (CleveLandContext ctx = new CleveLandContext())
            {
                return ctx.Medicos.ToList();
            }
        }
    }
}
