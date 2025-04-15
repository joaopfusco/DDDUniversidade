using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Infra.Repositories;
using DDDUniversidade.Service.Interfaces;
using DDDUniversidade.Service.Services;

namespace DDDUniversidade.API.Extensions
{
    internal static class RepositoryExtension
    {
        internal static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IEventoRepository, EventoRepository>();
            services.AddTransient<IPostagemRepository, PostagemRepository>();
            services.AddTransient<ISeguidorRepository, SeguidorRepository>();
            services.AddTransient<IParticipanteRepository, ParticipanteRepository>();

            return services;
        }
    }
}
