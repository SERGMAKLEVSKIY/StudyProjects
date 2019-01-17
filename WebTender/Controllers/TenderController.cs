using System.Net;
using System.Web.Mvc;
using WebTender.Models;
using WebTender.Services;

namespace WebTender.Controllers
{
    public class TenderController : Controller
    {
        private ITenderService tenderService;

        public TenderController(ITenderService tenderService)
        {
            this.tenderService = tenderService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            TenderModelWithFilter model = new TenderModelWithFilter();
            model.PageNumber = 1;
            model.SortOrder = "Category";
            model = tenderService.GetByFilter(model);

            return View(model);
        }

        

        [HttpPost]
        public ActionResult Index(TenderModelWithFilter model)
        {
            TenderModelWithFilter list = new TenderModelWithFilter();
            list = tenderService.GetByFilter(model);

            return View(list);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TenderModel model)
        {
            if (ModelState.IsValid)
            {
                tenderService.Create(model);
                return Redirect("index");
            }
            return View(model);
        }


        [HttpGet]
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = tenderService.GetById(Id.Value);
            return View(model);
        }
    }
}