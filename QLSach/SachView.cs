using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach
{
    public class SachView
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public bool TinhTrang { get; set; }
        public DateTime NXB { get; set; }
        public int ID_TacGia { get; set; }
        public string TenTacGia { get; set; }
    }
}
