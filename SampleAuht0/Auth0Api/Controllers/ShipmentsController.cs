using System.Web.Http;

namespace Auth0Api.Controllers
{
    [Authorize]
    public class ShipmentsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }

    }
}
