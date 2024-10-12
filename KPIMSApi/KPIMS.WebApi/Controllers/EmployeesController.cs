using KPIMS.Core.APIResponse.Generic;
using KPIMS.Core.APIResponse;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using Microsoft.AspNetCore.Mvc;
using KPIMS.Repos.Repositories.Administration;
using KPIMS.Core.Constants;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KPIMS.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly ILogger<EmployeesController> _logger;
        public EmployeesController(IEmployeeRepo employeeRepo, ILogger<EmployeesController> logger)
        {
            _employeeRepo = employeeRepo;
            _logger = logger;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        [ProducesResponseType(typeof(APIOperationResultGeneric<IEnumerable<DbEmployee>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<IEnumerable<DbEmployee>>>> GetEmployeesAsync()
        {
            try
            {
                return Ok(APIOperationResult.Success(await _employeeRepo.GetEmployeesAsync()));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        [HttpGet("employees-only")]
        [ProducesResponseType(typeof(APIOperationResultGeneric<IEnumerable<DbEmployee>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<IEnumerable<DbEmployee>>>> GetEmployeesOnlyAsync()
        {
            try
            {
                return Ok(APIOperationResult.Success(await _employeeRepo.GetEmployeesOnlyAsync()));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbEmployee>>> GetEmployeeByIdAsync(int id)
        {
            try
            {
                return Ok(APIOperationResult.Success(await _employeeRepo.GetEmployeeByIdAsync(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        [HttpGet("email")]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbEmployee>>> GetEmployeeByEmailAsync(string email)
        {
            try
            {
                return Ok(APIOperationResult.Success(await _employeeRepo.GetEmployeeByEmailAsync(email)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // POST api/<EmployeesController>
        [HttpPost]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbEmployee>>> SaveEmployeeAsync([FromForm] DbEmployee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(APIOperationResult.Success(await _employeeRepo.SaveEmployeeAsync(model)));
                }

                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ResponseMessage.BadRequest));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPut]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbEmployee>>> UpdateEmployeeAsync([FromForm] DbEmployee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(APIOperationResult.Success(await _employeeRepo.UpdateEmployeeAsync(model)));
                }

                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ResponseMessage.BadRequest));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<bool>>> DeleteEmployeeAsync(int id)
        {
            try
            {
                return Ok(APIOperationResult.Success(await _employeeRepo.DeleteEmployeeAsync(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }
    }
}
