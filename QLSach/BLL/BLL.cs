using QLSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.BLL
{
    public class BLL
    {
        private static BLL _Instance;
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private QLSach QLSach = new QLSach();
        
        public List<TacGia> GetAllTG()
        {
            List<TacGia> data = new List<TacGia>();
            data = QLSach.TacGias.Select(p => p).ToList();
            return data;
        }
        public List<Sach> GetAllSach()
        {
            List<Sach> data = new List<Sach>();
            data = QLSach.Sachs.Select(p => p).ToList();
            return data;
        }
        public TacGia GetTGWithID(int id)
        {
            return QLSach.TacGias.Find(id);
        }
        public Sach GetSachWithID(string id)
        {
            //return QLSach.Sachs.Where(p => p.MaSach.Equals(id)).SingleOrDefault();
            return QLSach.Sachs.Find(id);
        }
        public List<CBBItem> GetListCBBItem()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (TacGia i in GetAllTG())
            {
                data.Add(new CBBItem { Value = i.ID_TacGia, Text = i.TenTacGia });
            }
            return data;
        }
        public bool Is_EsxitID(string masach)
        {
            Sach s = QLSach.Sachs.Where(p => p.MaSach.Equals(masach)).SingleOrDefault();
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Edit_Sach (Sach s)
        {
            Sach sa = QLSach.Sachs.Find(s.MaSach);
            sa.TenSach = s.TenSach;
            sa.NXB = s.NXB;
            sa.TinhTrang = s.TinhTrang;
            sa.TG = s.TG;
            QLSach.SaveChanges();
        }
        public void Add_Sach(Sach s)
        {
            QLSach.Sachs.Add(s);
            QLSach.SaveChanges();
        }
        public List<Object> Show_Sach(int a)
        {
            List<Object> data = new List<Object>();
            if (a==0)
            {
                var result = from s in QLSach.Sachs
                             select new
                             {
                                 MaSach = s.MaSach,
                                 TenSach = s.TenSach,
                                 NgayXuatBan = s.NXB,
                                 TinhTrang = s.TinhTrang,
                                 TacGia = s.TG.TenTacGia,
                                 ID_TacGia = s.ID_TacGia
                             };
                data.AddRange(result.ToList());
            }
            else 
            {
                var result = from s in QLSach.Sachs
                             where s.ID_TacGia == a
                             select new
                             {
                                 MaSach = s.MaSach,
                                 TenSach = s.TenSach,
                                 NgayXuatBan = s.NXB,
                                 TinhTrang = s.TinhTrang,
                                 TacGia = s.TG.TenTacGia,
                                 ID_TacGia = s.ID_TacGia
                             };
                data.AddRange(result.ToList());
            }
            return data;
        }
        public List<Sach> Sort_Sach(string a)
        {
            if(a.Contains("Ten Sach"))
            {
                return QLSach.Sachs.OrderBy(p => p.TenSach).ToList();
            }    
            else 
            {
                return QLSach.Sachs.OrderBy(p => p.NXB).ToList();
            }    
        }

        public void Delete_Sach (List<string> masach)
        {
            //Sach delete = QLSach.Sachs.Where(p => p.MaSach.Equals(masach)).SingleOrDefault();
            for (int i=0; i< masach.Count; i++)
            {
                Sach delete = QLSach.Sachs.Find(masach[i]);
                QLSach.Sachs.Remove(delete);
            }    
            QLSach.SaveChanges();
        }
        
        public List<string> GetListMaSach()
        {
            List<string> data = new List<string>();
            foreach (Sach i in GetAllSach())
            {
                if (i.MaSach != null)
                {
                    data.Add(i.MaSach);
                }
            }
            return data;
        }
        public List<Sach> GetListDGV(List<string> ListMaSach)
        {
            List<Sach> data = new List<Sach>();
            foreach (string i in ListMaSach)
            {
                foreach (Sach j in GetAllSach())
                {
                    if (j.MaSach == i)
                    {
                            data.Add(j);
                    }
                }
            }
            return data;
        }
        public List<Sach> Search_Sach(List<Sach> s, string a)
        {
            List<Sach> data = new List<Sach>();
            foreach (Sach i in s)
            {
                if (i.TenSach.Contains(a))
                {
                    data.Add(i);
                }
                if (i.NXB.ToString().Contains(a))
                {
                     data.Add(i);
                }
                if (a.Contains("còn") && i.TinhTrang == true)
                {
                     data.Add(i);
                }
                if (a.Contains("hết") && i.TinhTrang == false)
                {
                     data.Add(i);
                }
                if (i.TG.TenTacGia.Contains(a))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<Object> Show_Sach_After(List<Sach> list)
        {
            List<Object> data = new List<Object>();
            foreach(Sach s in list)
            {
                var result = from sa in QLSach.Sachs
                             where sa.MaSach == s.MaSach
                             select new
                             {
                                 MaSach = s.MaSach,
                                 TenSach = s.TenSach,
                                 NgayXuatBan = s.NXB,
                                 TinhTrang = s.TinhTrang,
                                 TacGia = s.TG.TenTacGia,
                                 ID_TacGia = s.ID_TacGia
                             };

                data.AddRange(result.ToList());
            }               
            return data;
        }

        //public Sach Search_Sach_LINQ (string a)
        //{
        //    return (Sach)QLSach.Sachs.Where(p => p.MaSach.Equals(a));
        //}
        //public Sach GetSach(DataRow i)
        //{
        //    return new Sach
        //    {
        //        MaSach = Convert.ToInt32(i["MaSach"].ToString()),
        //        TenSach = i["TenSach"].ToString(),
        //        TinhTrang = Convert.ToBoolean(i["TinhTrang"].ToString()),
        //        NXB = Convert.ToDateTime(i["NXB"].ToString()),
        //        ID_TacGia = Convert.ToInt32(i["ID_TacGia"].ToString())
        //    };
        //}
        //public TacGia GetTG(DataRow i)
        //{
        //    return new TacGia
        //    {
        //        ID_TacGia = Convert.ToInt32(i["ID_TacGia"].ToString()),
        //        TenTacGia = i["TenTacGia"].ToString()
        //    };
        //}
        //public List<SachView> GetListSachViewByMaTacGia(int ID_TacGia)
        //{
        //    List<SachView> data = new List<SachView>();
        //    if (ID_TacGia == 0)
        //    {
        //        foreach (Sach i in GetAllSach())
        //        {
        //            data.Add(new SachView
        //            {
        //                MaSach = i.MaSach,
        //                TenSach = i.TenSach,
        //                TinhTrang = i.TinhTrang,
        //                NXB = i.NXB,
        //                ID_TacGia = i.ID_TacGia,
        //                TenTacGia = i.TG.TenTacGia //
        //            });
        //        }
        //    }
        //    else
        //    {
        //        foreach (Sach i in GetAllSach())
        //        {
        //            if ( i.ID_TacGia == ID_TacGia)
        //            {
        //                data.Add(new SachView
        //                {
        //                    MaSach = i.MaSach,
        //                    TenSach = i.TenSach,
        //                    TinhTrang = i.TinhTrang,
        //                    NXB = i.NXB,
        //                    ID_TacGia = i.ID_TacGia,
        //                    TenTacGia = i.TG.TenTacGia
        //                });
        //            }
        //        }
        //    }

        //    return data;
        //}
        //public string GetTenTGByMaTG(int MaTacGia)
        //{
        //    foreach (TacGia i in GetAllTG())
        //    {
        //        if (i.ID_TacGia == MaTacGia)
        //        {
        //            return i.TenTacGia;
        //        }
        //    }
        //    return null;
        //}
    }
}
