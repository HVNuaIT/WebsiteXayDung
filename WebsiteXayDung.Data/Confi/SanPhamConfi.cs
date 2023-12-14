using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteXayDung.Data.Entity;
using WebsiteXayDung.Data.Enum;

namespace WebsiteXayDung.Data.Confi
{
    public class SanPhamConfi : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
           builder.ToTable(nameof(SanPham));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(120);
            builder.Property(x => x.Status).HasDefaultValue(Status.Off);
            builder.Property(x => x.IdDanhMuc).IsRequired();
            builder.HasOne(x => x.DanhMuc).WithMany(x=>x.SanPham).HasForeignKey(x=>x.IdDanhMuc);
        }
    }
}
