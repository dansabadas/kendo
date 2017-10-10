using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIApp2.Models;

namespace KendoUIApp2.Controllers
{
  public class KendoMvcSamplesController : Controller
  {

    // GET: KendoMvcSamples
    public ActionResult Slider()
    {
      return View();
    }

    public ActionResult Editor()
    {
      return View();
    }

    public ActionResult Menu()
    {
      return View();
    }

    public ActionResult ServerGridBinding()
    {
      var knockoutRepo = new Entities();
      var orders = knockoutRepo.SalesOrders.ToList();
      ViewBag.Orders = orders;
      return View();
    }

    public ActionResult AjaxBinding()
    {
      return View();
    }

    public ActionResult Orders_Read([DataSourceRequest] DataSourceRequest request)
    {
      using (var northwind = new Entities())
      {
        IQueryable<SalesOrder> orders = northwind.SalesOrders;
        DataSourceResult result = orders.ToDataSourceResult(request);
        return Json(result);
      }
    }
  }
}