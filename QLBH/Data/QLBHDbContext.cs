using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLBH.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Kiểm tra an toàn để tránh lỗi NullReference khi chạy Migration
                var connSetting = ConfigurationManager.ConnectionStrings["QLBHConnection"];
                if (connSetting != null)
                {
                    optionsBuilder.UseSqlServer(connSetting.ConnectionString);
                }
                else
                {
                    // Chuỗi kết nối dự phòng để lệnh Add-Migration/Update-Database không bị văng lỗi
                    optionsBuilder.UseSqlServer("Server=LAPTOP-TUANANH; Database=QLBanHang; Integrated Security=True; TrustServerCertificate=True;");
                }
            }
        }
    }
}
