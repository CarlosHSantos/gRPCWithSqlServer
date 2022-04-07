using Grpc.Core;
using GrpcServer.Context;

namespace GrpcServer.Services
{
    public class UsuarioService : Usuario.UsuarioBase
    {
        private readonly ILogger<UsuarioService> _logger;
        private readonly DefaultDbContext _context;
        public UsuarioService(ILogger<UsuarioService> logger, DefaultDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<UsuarioModel> GetUsuarioById(UsuarioRequest request, ServerCallContext context)
        {
            UsuarioModel model = new UsuarioModel();

            var usuario = _context.Usuario.Find(request.Id);

            if (usuario == null)
            {
                return Task.FromResult(model);
            }

            model.Id = usuario.Id;
            model.Nome = usuario.Nome;
            model.Email = usuario.Email;
            model.SobreNome = usuario.SobreNome;
            model.Senha = usuario.Senha;

            return Task.FromResult(model);
        }
    }
}
