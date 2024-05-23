using Infrastructure.Data;
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

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest() { 
            
            if(false)
            {
                return NotFound(new ApiResponse(404));
            }
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
