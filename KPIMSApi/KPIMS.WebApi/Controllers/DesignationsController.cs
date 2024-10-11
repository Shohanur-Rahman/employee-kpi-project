using KPIMS.Core.APIResponse.Generic;
using KPIMS.Core.APIResponse;
using Microsoft.AspNetCore.Mvc;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using KPIMS.Core.UiModels;
using KPIMS.Core.Constants;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KPIMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationsController : ControllerBase
    {
        private readonly IDesignationRepo _designationRepo;
        private readonly ILogger<DesignationsController> _logger;
        public DesignationsController(IDesignationRepo designationRepo, ILogger<DesignationsController> logger)
        {
            _designationRepo = designationRepo;
            _logger = logger;
        }
        // GET: api/<DesignationsController>
        [HttpGet]
        [ProducesResponseType(typeof(APIOperationResultGeneric<IEnumerable<DbDesignation>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<IEnumerable<DbDesignation>>>> GetDesignationsAsync()
        {
            try
            {
                return Ok(APIOperationResult.Success(await _designationRepo.GetDesignationsAsync()));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }


        // GET api/<DesignationsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbDesignation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbDesignation>>> GetDesignationByIdAsync(int id)
        {
            try
            {
                return Ok(APIOperationResult.Success(await _designationRepo.GetDesignationByIdAsync(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // POST api/<DesignationsController>
        [HttpPost]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbDesignation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbDesignation>>> SaveDesignationAsync([FromForm] DbDesignation model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(APIOperationResult.Success(await _designationRepo.SaveDesignationAsync(model)));
                }

                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ResponseMessage.BadRequest));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // PUT api/<DesignationsController>/5
        [HttpPut]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbDesignation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<DbDesignation>>> UpdateDesignationAsync([FromForm] DbDesignation model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(APIOperationResult.Success(await _designationRepo.UpdateDesignationAsync(model)));
                }

                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ResponseMessage.BadRequest));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }

        // DELETE api/<DesignationsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(APIOperationResultGeneric<DbDesignation>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIOperationResultGeneric<bool>>> DeleteDesignationAsync(int id)
        {
            try
            {
                return Ok(APIOperationResult.Success(await _designationRepo.DeleteDesignationAsync(id)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, APIOperationResult.Failure(ex.Message));
            }
        }
    }
}
