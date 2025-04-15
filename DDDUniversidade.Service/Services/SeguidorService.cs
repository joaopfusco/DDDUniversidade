using DDDUniversidade.Domain.Models;
using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUniversidade.Service.Services
{
    public class SeguidorService(ISeguidorRepository repository) : BaseService<Seguidor>(repository), ISeguidorService
    {
        public override int Insert(Seguidor model)
        {
            if (model.SegueId == model.SeguidoId)
                throw new Exception("Não é possível seguir a si mesmo.");

            return base.Insert(model);
        }

        public override int Update(Seguidor model)
        {
            if (model.SegueId == model.SeguidoId)
                throw new Exception("Não é possível seguir a si mesmo.");

            return base.Update(model);
        }
    }
}
