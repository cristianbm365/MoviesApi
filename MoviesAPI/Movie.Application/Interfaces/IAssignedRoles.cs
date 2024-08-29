using Movie.Domain.Entities;
using Movie.Domain.Entities.Models;
using Movie.Domain.Entities.Users.Requirements;
using Movie.Domain.Entities.Users.Responses;

namespace Movie.Application.Interfaces
{
    public interface IAssignedRoles
    {
        Task<List<Roles>> ObtenerTodosLosRoles();

        Task<GenericResponse<LoginResponse>> RegistrarUsuario(LoginRequest loginRequest);

    }
}
