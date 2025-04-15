using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Infra.Repositories;
using DDDUniversidade.Service.Interfaces;
using DDDUniversidade.Service.Services;

namespace DDDUniversidade.API.Extensions
{
    internal static class ServiceExtension
    {
        internal static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IEventoService, EventoService>();
            services.AddTransient<IPostagemService, PostagemService>();
            services.AddTransient<ISeguidorService, SeguidorService>();
            services.AddTransient<IParticipanteService, ParticipanteService>();

            return services;
        }
    }
}
