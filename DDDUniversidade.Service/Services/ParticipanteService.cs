﻿using DDDUniversidade.Domain.Models;
using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUniversidade.Service.Services
{
    public class ParticipanteService(IParticipanteRepository repository, IEventoService eventoService) : BaseService<Participante>(repository), IParticipanteService
    {
        public override int Insert(Participante model)
        {
            if (Get().Any(p => p.EventoId == model.EventoId && p.UsuarioId == model.UsuarioId))
                throw new Exception("Usuário já inscrito nesse evento.");

            if (eventoService.Lotado(model.EventoId))
                throw new Exception("O evento está lotado.");

            return base.Insert(model);
        }
    }
}
