using Individuell_inlamning.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Individuell_inlamning.Controllers
{
    public class KrypteringController : ControllerBase
    {
        private readonly IService _service;
        

        public KrypteringController( IService service )
        {
            _service = service;
        }



    }
}
