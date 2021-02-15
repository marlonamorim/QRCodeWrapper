using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QrCodeWrapper.Services;

namespace QrCodeWrapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QrCodeWrapperController : ControllerBase
    {
        private readonly ILogger<QrCodeWrapperController> _logger;

        public QrCodeWrapperController(ILogger<QrCodeWrapperController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(string url)
        {
            var image = QrCodeGeneratorService.GenerateByteArray(url);
            return File(image, "image/jpeg");
        }
    }
}
