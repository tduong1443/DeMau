using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BaiThiController : Controller
    {
		QlhangHoaContext db = new QlhangHoaContext();
		public IActionResult Index()
        {
			List<HangHoa> lst = db.HangHoas.Where(h => h.Gia >= 100).ToList();
			return View(lst);
		}
        
        public IActionResult LoadHangHoa(int CartId)
        {
            List<HangHoa> lst = db.HangHoas.Where(h => h.MaLoai == CartId).ToList();
            return PartialView("View", lst);
        }

        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(db.LoaiHangs, "MaLoai", "TenLoai");
            return View();
        }

        [HttpPost]
        public IActionResult Create(HangHoa lst)
        {
            db.HangHoas.Add(lst);
            db.SaveChanges();
            return Redirect("Index");
        }
    }
}
