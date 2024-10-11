using KPIMS.Core.APIResponse.Generic;
using KPIMS.Core.APIResponse;
using KPIMS.Core.Constants;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using Microsoft.AspNetCore.Mvc;
using KPIMS.Core.UiModels;
using KPIMS.Core.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using KPIMS.WebApi.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KPIMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly ILogger<AccountsController> _logger;
        public readonly ConfigSettings _configuration;

        public AccountsController(IEmployeeRepo employeeRepo, ILogger<AccountsController> logger, ConfigSettings configuration)
        {
            _employeeRepo = employeeRepo;
            _logger = logger;
            _configuration = configuration;
        }

        [Route("SignIn")]
        [HttpPost]
        [ProducesResponseType(typeof(APIOperationResultGeneric<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<APIOperationResultGeneric<string>>> GetAuthorizedUser([FromBody] LoginModel model)
        {
            try
            {
                DbEmployee? user = await _employeeRepo.GetAutheticateEmployeeAsync(model);

                if (user is null)
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, APIOperationResult.Failure(ResponseMessage.LoginInvalidPassword));
                }
                return Ok(BusinessOperationResult.Success(GenerateJwtToken(user)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }



        #region Private methods
        private string GenerateJwtToken(DbEmployee result)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_configuration.GetJWTKey());
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                        new Claim(ClaimTypes.Authentication, result.Id.ToString()),
                    new Claim(ClaimTypes.Email, result.Email.ToString()),
                    new Claim(ClaimTypes.Name,result.FullName),
                    new Claim(ClaimTypes.Role, result.Designation?.Name.ToString()),
                    new Claim(ClaimTypes.UserData, (string.IsNullOrEmpty(result.Avatar)?"images/avatar/1.png":result.Avatar)),
                    }),

                Expires = DateTime.UtcNow.AddDays(30),

                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenDetails = tokenHandler.CreateToken(tokenDescription);

            var jwtToken = tokenHandler.WriteToken(tokenDetails);

            return jwtToken;
        }
        #endregion
    }
}
