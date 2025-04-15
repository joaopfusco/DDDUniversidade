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
    public class ParticipanteRepository(AppDbContext db) : BaseRepository<Participante>(db), IParticipanteRepository
    {
    }
}
