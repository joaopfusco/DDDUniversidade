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
    public class PostagemService(IPostagemRepository repository) : BaseService<Postagem>(repository), IPostagemService
    {

    }
}
