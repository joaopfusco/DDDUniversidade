﻿using DDDUniversidade.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUniversidade.Service.Interfaces
{
    public interface IEventoService : IBaseService<Evento>
    {
        public bool Lotado(int eventoId);
    }
}
