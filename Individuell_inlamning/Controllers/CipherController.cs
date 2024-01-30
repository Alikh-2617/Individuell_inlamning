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
        private readonly IService _service;

        public CipherController(IService service)
        {
            _service = service;
        }

        [HttpPost("encrypt")]
        public ActionResult<string> Encrypt(Model model)
        {
            try
            {
                string cypher_text = _service.Encrypt(model);
                return Ok(cypher_text);
            }
            catch (Exception ex)
            {
                return BadRequest("det har händ något fel !");
            }
        }

        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt(Model model)
        {
            try
            {
                string text = _service.Decrypt(model);
                return Ok(text);
            }
            catch(Exception ex)
            {
                return BadRequest("det har händ något fel !");
            }
        }
    }
}
