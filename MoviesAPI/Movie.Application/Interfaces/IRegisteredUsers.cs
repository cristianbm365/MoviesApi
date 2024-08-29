using Movie.Domain.Entities;
using Movie.Domain.Entities.Models;
using Movie.Domain.Entities.Users.Requirements;
using Movie.Domain.Entities.Users.Responses;

namespace Movie.Application.Interfaces
{
    public interface IRegisteredUsers
    {
        Task<GenericResponse<Users>> ObtenerUsuariosXId(int UserId);

        Task<List<Users>> ObtenerTodosLosUsuarios();

        Task<GenericResponse<LoginResponse>> RegistrarUsuario(LoginRequest loginRequest);
    }
}
