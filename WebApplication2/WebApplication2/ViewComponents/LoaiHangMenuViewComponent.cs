using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Reponsitory;

namespace WebApplication2.ViewComponents
{
	public class LoaiHangMenuViewComponent : ViewComponent
	{
		private readonly ILoaiHangReponsitory iloaiHang;
		public LoaiHangMenuViewComponent(ILoaiHangReponsitory iloaiHang)
		{
			this.iloaiHang = iloaiHang;
		}
		public IViewComponentResult Invoke()
		{
			var loaihang = iloaiHang.GetAll().OrderBy(x => x.MaLoai);
			return View(loaihang);
		}
	}
}
