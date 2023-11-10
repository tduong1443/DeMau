using WebApplication2.Models;

namespace WebApplication2.Reponsitory
{
	public interface ILoaiHangReponsitory
	{
		LoaiHang Add(LoaiHang loaiHang);
		LoaiHang Update(LoaiHang loaiHang);
		LoaiHang Delete(int Ma);
		LoaiHang Get(int Ma);
		IEnumerable<LoaiHang> GetAll();
	}
}
