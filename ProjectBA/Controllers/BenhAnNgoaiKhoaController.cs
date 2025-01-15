using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ProjectBA.Models.Entities;
using ProjectBA.Services;
using WkHtmlToPdfDotNet;
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
        private static IWebHostEnvironment _hostingEnvironment;

        public BenhAnNgoaiKhoaController(ILogger<HomeController> logger, IBenhAnNgoaiKhoaServices services, HospitalContext context, IConverter converter, ICompositeViewEngine viewEngine, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _services = services;
            _context = context;
            _converter = converter;
            _viewEngine = viewEngine;
            _hostingEnvironment = webHostEnvironment;
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

        /*public static string ConvertImageToBase64(IWebHostEnvironment h, string imagePath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(h.WebRootPath + imagePath);
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }
        public static string pathImageToString(string imagePath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(_hostingEnvironment.WebRootPath + imagePath);
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }
        public static string ConvertViewToString(ControllerContext controllerContext, PartialViewResult pvr, ICompositeViewEngine _viewEngine)
        {
            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult vResult = _viewEngine.FindView(controllerContext, pvr.ViewName, false);
                ViewContext viewContext = new ViewContext(controllerContext, vResult.View, pvr.ViewData, pvr.TempData, writer, new HtmlHelperOptions());

                vResult.View.RenderAsync(viewContext);

                return writer.GetStringBuilder().ToString();
            }
        }

        [HttpPost("PDFBANgoaiTruMat")]
        public async Task<dynamic> PDFBANgoaiTruMat()
        {
            var data = await _services.ThongTin;

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = WkHtmlToPdfDotNet.PaperKind.A4,
                Margins =
                {
                    Top = 0.5,
                    Left = 0.5,
                    Right = 0.5,
                    Bottom = 0.5,
                    Unit = Unit.Centimeters
                },
            },
            };
            ViewBag.matPhai1 = ConvertImageToBase64(_hostingEnvironment, "/img/matphai.png");
            ViewBag.matTrai1 = ConvertImageToBase64(_hostingEnvironment, "/img/mattrai.png");

            ViewBag.matPhai2 = ConvertImageToBase64(_hostingEnvironment, "/img/matphai2.jpeg");
            ViewBag.matTrai2 = ConvertImageToBase64(_hostingEnvironment, "/img/mattrai2.jpeg");
            PartialViewResult partialViewResult = PartialView("PDFBANgoaiTruMat", data);
            string viewContent = ConvertViewToString(ControllerContext, partialViewResult, _viewEngine);

            doc.Objects.Add(new ObjectSettings()
            {
                PagesCount = true,
                HtmlContent = viewContent,
                WebSettings = { DefaultEncoding = "utf-8",
        LoadImages = true
        },
                FooterSettings = {
                       Right = "[page]",
                   }
            });

            var pdfBytes = _converter.Convert(doc);
            return File(pdfBytes, "application/pdf", "output.pdf");
        }*/

    }
}
