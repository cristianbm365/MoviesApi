using Microsoft.AspNetCore.Mvc;
using Movie.Application.Interfaces;
using Movie.Domain.Entities.Users.Requirements;

namespace Movie.API.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {        
        private readonly IRegisteredUsers _registeredUsers;

        public UsersController(IRegisteredUsers registeredUsers)
        {
            _registeredUsers = registeredUsers;
        }

        [HttpPost]
        [Route("ObtenerUsuariosXId")]
        public async Task<ActionResult> ObtenerUsuariosXId([FromBody] int Id)
        {
            var user = await _registeredUsers.ObtenerUsuariosXId(Id);

            return Ok(user);
        }


        [HttpPost]
        [Route("ObtenerTodosLosUsuarios")]
        public async Task<ActionResult> ObtenerTodosLosUsuarios()
        {
            var actividad = await _registeredUsers.ObtenerTodosLosUsuarios();

            return Ok(actividad);
        }

        [HttpPost]
        [Route("RegistrarUsuario")]
        public async Task<ActionResult> RegistrarUsuario([FromBody] LoginRequest loginRequest)
        {
            var actividad = await _registeredUsers.RegistrarUsuario(loginRequest);

            return Ok(actividad);
        }
    }
}
