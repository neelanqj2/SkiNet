using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkiNet.Errors;

namespace SkiNet.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("testauth")]
        [Authorize]
        public ActionResult<string> GetSecretText()
        {
            return "Secret stuff";
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest() { 
            
            return Ok(); 
        }

        [HttpGet("servererror")]
        public ActionResult GetServerErrorRequest()
        {
            var thing = _context.Products.Find(42);

            var thingToReturn = thing.ToString();

            return Ok(); 
        }

        [HttpGet("badrequest")]
        public ActionResult GetBadRequest() {
            if (false)
            {
                return BadRequest(new ApiResponse(400));
            }
            return BadRequest(); 
        }

        [HttpGet("badrequest/{id}")]
        public ActionResult GetBadRequest(int id) { return BadRequest(); }
    }
}
