using mabextendedFETest.Manager.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mabextendedFETest.Utility;
using System;

namespace mabextendedFETest.API.Controllers
{
    [ApiController]
    public class PlayersController : ControllerBase
    {
        IPlayersManager Manager;
        ValidationResult ValidationResult;

        public PlayersController(IPlayersManager manager)
        {
            Manager = manager;
            ValidationResult = new ValidationResult();
        }

       

        [HttpGet]
        [Route(APIEndpoint.DefaultRoute)]
        public ActionResult Get(int page = 1, int itemsPerPage = 100)
        {
            try
            {
                if (page <= 0)
                {
                    ValidationResult.AddFieldError("Id", "Invalid page number");
                }
                if (ValidationResult.IsError)
                {
                    return BadRequest(new APIResponse(ResponseCode.ERROR, "Validation failed", ValidationResult));
                }
                return Ok(Manager.GetPlayers(page, itemsPerPage));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, "Exception", ex.Message));
            }
        }
        [HttpGet]
        [Route(APIEndpoint.DefaultRoute + "/search")]
        public ActionResult Search(string searchKey, int page = 1, int itemsPerPage = 100)
        {
            try
            {
                if (string.IsNullOrEmpty(searchKey))
                {
                    ValidationResult.AddEmptyFieldError("SearchKey");
                }
                else if (!string.IsNullOrEmpty(searchKey) && searchKey.Length < 3)
                {
                    ValidationResult.AddFieldError("SearchKey", "Minimum 3 chracters required for search");
                }
                if (page <= 0)
                {
                    ValidationResult.AddFieldError("Id", "Invalid page number");
                }
                if (ValidationResult.IsError)
                {
                    return BadRequest(new APIResponse(ResponseCode.ERROR, "Validation failed", ValidationResult));
                }
                return Ok(Manager.SearchPlayers(searchKey, page, itemsPerPage));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, "Exception", ex.Message));
            }
        }

        [HttpGet]
        [Route(APIEndpoint.DefaultRoute + "/{playerid}")]
        public ActionResult GetById(int playerid)
        {
            try
            {
                if (playerid <= 0) { ValidationResult.AddEmptyFieldError("playerid"); }

                if (ValidationResult.IsError)
                {
                    return BadRequest(new APIResponse(ResponseCode.ERROR, "Validation failed", ValidationResult));
                }
                return Ok(Manager.GetPlayersByID(playerid));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, "Exception", ex.Message));
            }
        }

    }
}
