using WebApplication2.Models;

namespace WebApplication2.Reponsitory
{
    public class LoaiHangReponsitory : ILoaiHangReponsitory
    {
		QlhangHoaContext context = new QlhangHoaContext();
		public LoaiHang Add(LoaiHang loaiHang)
        {
            context.LoaiHangs.Add(loaiHang);
            context.SaveChanges();
            return loaiHang;
        }

        public LoaiHang Delete(int Ma)
        {
            throw new NotImplementedException();
        }

        public LoaiHang Get(int Ma)
        {
            return context.LoaiHangs.Find(Ma);
        }

        public IEnumerable<LoaiHang> GetAll()
        {
            return context.LoaiHangs;
        }

        public LoaiHang Update(LoaiHang loaiHang)
        {
            context.Update(loaiHang);
            context.SaveChanges() ;
            return loaiHang;
        }
    }
}
