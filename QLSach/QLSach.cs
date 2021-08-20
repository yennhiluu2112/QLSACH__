using QLSach.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace QLSach
{
    public class QLSach : DbContext //lop chiu trach n tuong tac voi CSDL (truy van, quan ly, anh xa,...)
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QLSach.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        //Ctrl+R+R: thay doi ten toan bo
        //Chien luoc khoi tao: da co roi su dung luon, xoa cai cu tao cai moi, luon luon xoa cai cu tao cai moi
        public QLSach()
            : base("name=QLSach")
        {
            Database.SetInitializer<QLSach>(new CreateTable()); //khoi tao du lieu co san cho database, tao thuc the theo chien luoc khoi tao
        }

        public virtual DbSet <Sach> Sachs { get; set; } //dai dien cho thuc the co trong CSDL, anh xa tu CSDL qua, thuc hien thao tac: xem xoa sua doc
        public virtual DbSet <TacGia> TacGias { get; set; } //dung virtual neu muon override tra ve kieu DbSet khac 

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}