using QLSach.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach
{
    class CreateTable : CreateDatabaseIfNotExists<QLSach>
    //DropCreateDatabaseAlways<QLSach>
    //
    //DropCreateDatabaseIfModelChanges<QLSV>

    {
        protected override void Seed(QLSach context)
        {
            context.Sachs.AddRange(new Sach[]
            {
                new Sach(){MaSach = "100", TenSach ="Sach1", NXB = new DateTime(2000,5,6), TinhTrang= true, ID_TacGia=1},                
                new Sach(){MaSach = "101", TenSach ="Sach2", NXB = new DateTime(2000,4,6), TinhTrang= true, ID_TacGia=1},
                new Sach(){MaSach = "103", TenSach ="Sach3", NXB = new DateTime(2003,5,8), TinhTrang= true, ID_TacGia=2},
            });
            context.TacGias.AddRange(new TacGia[]
            {

                new TacGia(){ID_TacGia=1, TenTacGia="TacGia1"},
                new TacGia(){ID_TacGia=2, TenTacGia="TacGia2"}

            });
        }

    }
}
