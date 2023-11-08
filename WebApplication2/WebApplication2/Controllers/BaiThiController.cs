using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BaiThiController : Controller
    {
        public IActionResult Index()
        {
            QlhangHoaContext db = new QlhangHoaContext();
			List<HangHoa> lst = db.HangHoas.Where(h => h.Gia >= 100).ToList();
			return View(lst);
		}
       
        //public ActionResult Products()
        //{
        //    QlhangHoaContext db = new QlhangHoaContext();
        //    List<HangHoa> lst = db.HangHoas.Where(h => h.Gia >= 100).ToList();
        //    return PartialView("NguyenThiThuyDuong_Main", lst);
        //}
    }
}
