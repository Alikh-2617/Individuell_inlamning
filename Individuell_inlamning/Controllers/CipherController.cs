using Individuell_inlamning.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Individuell_inlamning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CipherController : ControllerBase
    {
        protected Service service = new Service();

        [HttpPost("encrypt")]
        public ActionResult<string> Encrypt(Model model)
        {
            if (ModelState.IsValid)
            {
                string cypher_text = service.Encrypt(model);
                return Ok(cypher_text);
            }
            return BadRequest("Det har hänt någor fel, försöt igen !");
        }

        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt(ModelDto model)
        {
            if (ModelState.IsValid)
            {
                string text = service.Decrypt(model)!;
                if(text != null)
                {
                    return Ok(text);
                }
                return BadRequest("Användare hittades inte, vi kan inte dekryptera den!");
            }
            return BadRequest("det har händ något fel, ");

        }
    }
}
