using DDDUniversidade.Domain.DTOs;
using DDDUniversidade.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace DDDUniversidade.Infra.Repositories
{
    public class SeguidorRepository(AppDbContext db) : BaseRepository<Seguidor>(db), ISeguidorRepository
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
