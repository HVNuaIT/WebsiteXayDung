using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Data.Confi;
using WebsiteXayDung.Data.Entity;

namespace WebsiteXayDung.Data.EF
{
    public class XayDungDb:DbContext
    {
        public XayDungDb(DbContextOptions options) : base(options) { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DanhMucConfi());
            //modelBuilder.ApplyConfiguration(new QuyenConfi());
            modelBuilder.ApplyConfiguration(new SanPhamConfi());
            //modelBuilder.ApplyConfiguration(new SanPhamDanhMucConfi());
            //modelBuilder.ApplyConfiguration(new TaiKhoanConfi());
            //modelBuilder.ApplyConfiguration(new CartConfi());
            //modelBuilder.ApplyConfiguration(new OrderConfi());
            //modelBuilder.ApplyConfiguration(new HinhAnhSanPhamConfi());
           
          //  modelBuilder.Seed();
            // base.OnModelCreating(modelBuilder);
        }
        public DbSet<SanPham> ?SanPhams { get; set; }
        public DbSet<DanhMuc> ?DanhMucs { get; set; }
        public DbSet<GioiThieu>? GioiThieus { get; set; }
        public DbSet<HinhAnh> ?HinhAnhs { get; set; }
        public DbSet<ThongTinDoanhNghiep>? ThongTinDoanhNghieps { get; set; }
        public DbSet<Team>? Teams { get; set; }
        public DbSet<ViTri>? ViTris { get; set; }

    }
}
