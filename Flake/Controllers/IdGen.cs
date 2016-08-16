using System.Web.Http;
using System.Web.Http.Description;

namespace Flake.Controllers
{
    public class IdController : ApiController
    {
        /// <summary>
        /// Get a Flake ID.
        /// </summary>
        /// <returns>The next Flake ID as a string</returns>
        [HttpGet]
        [Route("next")]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetId()
        {
            return Ok(IdGen.Instance.GenerateId().ToString());
        }

        /// <summary>
        /// Format a Flake ID.
        /// </summary>
        /// <returns>A formatted Flake ID as a string</returns>
        [HttpGet]
        [Route("format")]
        [ResponseType(typeof(string))]
        public IHttpActionResult FormatId(string Id)
        {
            return Ok(System.Text.RegularExpressions.Regex.Replace(Id, @"^(.{4})(.{7})", "$1-$2-"));
        }
    }
}
