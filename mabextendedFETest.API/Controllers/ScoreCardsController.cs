using mabextendedFETest.Manager.Interfaces;
using mabextendedFETest.Utility;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mabextendedFETest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreCardsController : ControllerBase
    {
        IScoreCardsManager Manager;
        ValidationResult ValidationResult;
        public ScoreCardsController(IScoreCardsManager manager)
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
                return Ok(Manager.GetScoreCards(page, itemsPerPage));
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
                return Ok(Manager.SearchScoreCards(searchKey, page, itemsPerPage));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, "Exception", ex.Message));
            }
        }


    }
}
