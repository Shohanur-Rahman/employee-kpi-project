using KPIMS.Core.APIResponse.Generic;
using KPIMS.Core.APIResponse;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Administration;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KPIMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeProfilesController : ControllerBase
    {
        private readonly IEmployeeProfileRepo _employeeProfileRepo;
        private readonly ILogger<EmployeeProfilesController> _logger;
        public EmployeeProfilesController(IEmployeeProfileRepo employeeProfileRepo, ILogger<EmployeeProfilesController> logger)
        {
            _employeeProfileRepo = employeeProfileRepo;
            _logger = logger;
        }
        // GET: api/<EmployeeProfilesController>
        [HttpGet]
        [ProducesResponseType(typeof(APIOperationResultGeneric<IEnumerable<DbEmployeeProfile>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<IEnumerable<DbEmployeeProfile>>>> GetEmployeeProfilesAsync()
        {
            try
            {
                return Ok(APIOperationResult.Success(await _employeeProfileRepo.GetEmployeeProfilesAsync()));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // GET api/<EmployeeProfilesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeProfilesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeProfilesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeProfilesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
