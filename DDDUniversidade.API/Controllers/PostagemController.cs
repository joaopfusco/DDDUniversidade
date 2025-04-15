using System.Net;
using DDDUniversidade.Domain.DTOs;
using DDDUniversidade.Domain.Models;
using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.Extensions.Logging;

namespace DDDUniversidade.API.Controllers
{
    public class PostagemController(IPostagemService service, ILogger<PostagemController> logger) : BaseController<Postagem>(service, logger)
    {
    }
}
