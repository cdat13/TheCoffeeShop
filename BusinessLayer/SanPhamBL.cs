using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessLayer;
using DataLayer;
using DataTranfer;

namespace BusinessLayer
{
    public class SanPhamBL
    {
        private SanPhamDL dal = new SanPhamDL();

        public List<SanPham> GetAll() => dal.GetSanPhams();
        public void Add(SanPham p) => dal.ThemSanPham(p);
        public void Update(SanPham p) => dal.CapNhatSanPham(p);
        public void Delete(int id) => dal.XoaSanPham(id);
    }

}
