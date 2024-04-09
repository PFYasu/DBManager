using Microsoft.AspNetCore.Mvc;

namespace DBManager.Server.Controllers
{
    [ApiController]
    public class ConnectionListController : ControllerBase
    {
        [HttpGet]
        [Route("/api/v1/connection-list/get-connections")]
        public IActionResult GetConnections()
        {
            return Ok(new List<Connection>
            {
                new() {
                    Date = DateTime.UtcNow,
                    Summary = "summary",
                }
            });
        }
    }
}
