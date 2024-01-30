using Microsoft.AspNetCore.Mvc;

namespace Individuell_inlamning.Controllers
{
    public class KrypteringController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public KrypteringController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        //public IActionResult Index()
        //{
        //    return ;
        //}
    }
}
