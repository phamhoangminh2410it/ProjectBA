using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using ProjectBA.Models.Entities;
using ProjectBA.Services;
using WkHtmlToPdfDotNet.Contracts;

namespace ProjectBA.Controllers
{
    [Route("QuanLy/[Controller]")]
    public class BenhAnNgoaiKhoaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBenhAnNgoaiKhoaServices _services;
        private readonly HospitalContext _context;
        private readonly IConverter _converter;
        private readonly ICompositeViewEngine _viewEngine;

        public BenhAnNgoaiKhoaController(ILogger<HomeController> logger, IBenhAnNgoaiKhoaServices services, HospitalContext context, IConverter converter, ICompositeViewEngine viewEngine)
        {
            _logger = logger;
            _services = services;
            _context = context;
            _converter = converter;
            _viewEngine = viewEngine;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("ViewData")]
        public async Task <IActionResult> ViewData()
        {
            var rs = await _services.ThongTin();
            return Ok(rs);
        }

        [HttpPost("AddData")]
        public async Task <IActionResult> AddData([FromBody] Benhanngoaikhoa benhanngoaikhoa)
        {
            var rs = await _services.ThemThongTin(benhanngoaikhoa);
            return Ok(rs);
        }
    }
}
