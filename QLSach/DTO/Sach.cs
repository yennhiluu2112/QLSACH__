using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.DTO
{
    [Table ("Sach")] //chu thich thuoc tinh
    public class Sach
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NXB { get; set; }
        public bool TinhTrang { get; set; }
        public int ID_TacGia { get; set; } //trung voi TacGia nen mac dinh la foreign key
        
        //public int ID_TG { get; set; } neu khong trung thi dat khoa ngoai nv 
        [ForeignKey("ID_TacGia")]
        public virtual TacGia TG { get; set; } //tham chieu den bang TacGia
    }
}
